using System;
using System.Security.Cryptography.X509Certificates;

namespace _09_files_en_directories_owen
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DirectoryInfo dir;
            Console.WriteLine("Hello, World!");
            string pad = @"C:\Users\owens\Desktop\ma\bewijzenmap\schooljaar 1\periode1.4\prog";
            dir = new DirectoryInfo(pad);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            for (int i = 0; i < dirs.Length; i++) 
            {
                Console.WriteLine(dirs[i].FullName);

            }
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.FullName);
            }

        }
    }
}