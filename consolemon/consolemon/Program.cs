﻿namespace consolemon
{
    internal class Program
    {
        static void Main(string[] args)    
        {
            Console.WriteLine("Hello, World!");
           TestConsoleMonFunctions();
        }
        static void TestSkillFunctions()
        {
            Console.WriteLine("TestSkillFunctions");
            ConsoleMon casterMon = new ConsoleMon();
            ConsoleMon targetMon = new ConsoleMon();
            Skill skill = new Skill()
            {
                damage = 100,
                energyCost = 20,
            };
            skill.UseOn(targetMon, casterMon);

            Console.WriteLine(targetMon.health == -100);

            Console.WriteLine(casterMon.energy == -20);
        }

    }
     
 }