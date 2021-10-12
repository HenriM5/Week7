using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta parool:");
                string userPassword = Console.ReadLine();
                if (userName == "Admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti. {3 - i} katset on jäänud.");
                }

            }

            Console.WriteLine("Kena päeva");
        }
    }
}
