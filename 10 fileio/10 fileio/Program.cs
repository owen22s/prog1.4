namespace _10_fileio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content;
            string extraRegel = "Dit is de extra regel.";
            string filePath = "text.txt";
            string schrijfFile = "schrijven.txt";
            Console.WriteLine("Hello, World!");
            File.WriteAllText(schrijfFile, extraRegel);
            content = File.ReadAllLines(filePath);
            Directory.CreateDirectory(filePath);
            foreach (string line in content)
            {
                Console.WriteLine(line);
            }
        }
    }
}