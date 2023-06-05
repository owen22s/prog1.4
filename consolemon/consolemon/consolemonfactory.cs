using System;
using System.IO;

internal class ConsoleMonFactory
{
    internal void Load(string datafile)
    {
        string[] lines = File.ReadAllLines(datafile);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        
        string filePath = "monsterdata.txt";
        string fileContent = File.ReadAllText(filePath);

        
        string[] fileLines = fileContent.Split('|');

        
        for (int i = 0; i < fileLines.Length; i++)
        {
            
            string[] typeSplit = fileLines[i].Split('|');
            
            string[] consoleMonData = typeSplit[0].Split(',');
            string waarde1 = consoleMonData[0];
            string waarde2 = consoleMonData[1];
            string waarde3 = consoleMonData[2];
            string waarde4 = consoleMonData[3];
            Console.WriteLine("Waarde 1: " + waarde1);
            Console.WriteLine("Waarde 2: " + waarde2);
            Console.WriteLine("Waarde 3: " + waarde3);
            Console.WriteLine("Waarde 4: " + waarde4);

        }

    }
}

