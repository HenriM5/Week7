using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string name = Console.ReadLine();

            
                for (int i = name.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(name[i]);
                }
                
                
                

                 

            




            



        }
    }
}
