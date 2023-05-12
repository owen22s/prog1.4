using System;

namespace consolemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TestSkillFunctions();
            TestConsoleMonFunctions();
        }

        static void TestSkillFunctions()
        {
            Console.WriteLine("TestSkillFunctions");
            ConsoleMon casterMon = new ConsoleMon();
            ConsoleMon targetMon = new ConsoleMon();
            Skill skill = new Skill(100, 20, "SomeSkill");
            skill.UseOn(targetMon, casterMon);

            Console.WriteLine(targetMon.health == -100);
            Console.WriteLine(casterMon.Energy == -20);
        }



        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions");
            // Add test cases for ConsoleMon class here
        }
    }
}
