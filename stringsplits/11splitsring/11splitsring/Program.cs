using System;
using System.IO;

namespace SplitOpdracht
{
    internal class Program
    {
        public static string content;

        public static void ReadAllText()
        {
            content = File.ReadAllText("stringsplit.txt");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ReadAllText();

            string[] keyValue = content.Split(':');

            if (keyValue.Length > 1)
            {
                string[] cijfersPerVak = keyValue[1].Split(',');

                foreach (string cijfer in cijfersPerVak)
                {
                    Console.WriteLine(cijfer);
                }
            }
        }
    }
}
