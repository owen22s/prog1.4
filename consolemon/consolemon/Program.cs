namespace consolemon
{
    internal class Program
    {
        static void Main(string[] args)    
        {
            Console.WriteLine("Hello, World!");
        }
        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions");
            ConsoleMon mon = new ConsoleMon();
            mon.TakeDamage(100);
            mon.DepleteEnergy(20);

            Console.WriteLine(mon.Health == -100);

            Console.WriteLine(mon.Energy == -20);
        }
        
    }
     
 }