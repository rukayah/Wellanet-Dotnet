using System;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Welcome, how old are you");
            age = int.Parse(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("You are old enough to drink");
            }
            else
            {
                Console.WriteLine("You should never drink");
            }
        }
    }
}
