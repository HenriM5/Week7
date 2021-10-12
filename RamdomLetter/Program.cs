using System;

namespace RamdomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesa oma eesnimi");
            string name = Console.ReadLine();
            Random random = new Random();
            const string chars = "BigBoiPeter";
            int index = random.Next(0, name.Length);
            Console.WriteLine($"{name[index]}");
        }
    }
}
