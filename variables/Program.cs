using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string personName = " ";
            Console.Write("Please enter your name: ");

            personName = Console.ReadLine();

            Console.WriteLine("Hello " + personName);
        }
    }
}

