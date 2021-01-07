using System;

namespace Clubentry
{
    class Program
    {
        static void Main(string[] args)
        {
            int susanAge, christianaAge, joelAge;

            Console.WriteLine("Welcome susan, how old are you please?");
            susanAge = int.Parse(Console.ReadLine());

            if(susanAge >= 18)
            {
                Console.WriteLine("You are welcome to our club Susan");
            } 
            else 
            {
                Console.WriteLine("You are not allowed in the club");
            }

            Console.WriteLine("Welcome christiana, how old are you please?");
            christianaAge = int.Parse(Console.ReadLine());

            if(christianaAge >= 18)
            {
                Console.WriteLine("You are welcome to our club Christiana");
            } 
            else 
            {
                Console.WriteLine("You are not allowed in the club");
            }
            Console.WriteLine("Welcome joel, how old are you please?");
            joelAge = int.Parse(Console.ReadLine());

            if(joelAge >= 18)
            {
                Console.WriteLine("You are welcome to our club Joel");
            } 
            else 
            {
                Console.WriteLine("You are not allowed in the club");
            }
        }
    }
}