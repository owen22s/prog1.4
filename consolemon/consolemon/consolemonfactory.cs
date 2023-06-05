using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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

    internal void LoadJson(string datafile)
    {
        string json = File.ReadAllText(datafile);
        Console.WriteLine(json);

        List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
        Console.WriteLine(templates[0].name);
    }
}

public class Skill
{
    public string name { get; set; }
    public int power { get; set; }
    public int cost { get; set; }
}

public class ConsoleMon
{
    public string name { get; set; }
    public int health { get; set; }
    public int attack { get; set; }
    public int defense { get; set; }
    public List<Skill> skills { get; set; }
}

public class Program
{
    static void Main()
    {
        TestFactoryFunctions();
    }

    static void TestFactoryFunctions()
    {
        Console.WriteLine("TestFactoryFunctions");
        ConsoleMonFactory factory = new ConsoleMonFactory();
        factory.Load("monsterdata.txt");
        factory.LoadJson("monsterdata.json");
    }
}
