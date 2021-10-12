using System;

namespace Week7Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("And what is your last name?");
            string LastName = Console.ReadLine();
            Console.WriteLine("Hello," + FirstName[0] + " " + LastName[0]);

        }
    }
}
