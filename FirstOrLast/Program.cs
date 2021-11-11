using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine();

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine(firstName);
            }
            else
                Console.WriteLine(lastName);
        }
    }
}
