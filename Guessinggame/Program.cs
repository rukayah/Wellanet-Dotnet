
using System;

namespace Guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 0;
            string name = " ";
            Console.Write("Hello! What is your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Hi " + name + " Let us play a guessing game");
            Console.WriteLine("In this game, you have three levels:");
            Console.WriteLine("1 means easy");
            Console.WriteLine("2 means Intermediate");
            Console.WriteLine("3 means hard");
            Console.WriteLine(name + " Kindly chose your level");
            level = int.Parse(Console.ReadLine());
            Console.WriteLine("You chose level" + level);

            int level1 = 1;
            int level2 = 2;
            int level3 = 3;

            if(level == level1)
            {
                Console.WriteLine("You have 6 trials");
                Console.WriteLine("Guess a number between 1 - 10");

                for(int i = 0; i < 6; i++)
                {
                    int input = 0;
                    int rand_num = new Random().Next(1, 10);
                    Console.Write("Enter a guess: ");
                    input = int.Parse(Console.ReadLine());

                    if(input != rand_num)
                    {
                        Console.WriteLine("Please try again");
                    }
                    else if(input == rand_num)
                    {
                        Console.WriteLine("Nice one, You won");
                        break;
                    }
                }
            }

            if(level == level2)
            {
                Console.WriteLine("You have 4 trials");
                Console.WriteLine("Guess a number between 1 to 20");

                for(int i = 0; i < 4; i++)
                {
                    int input = 0;
                    int rand_num = new Random().Next(1,20);
                    Console.Write("Enter a guess: ");
                    input = int.Parse(Console.ReadLine());

                    if(input != rand_num)
                    {
                        Console.WriteLine("Please try again");
                    }
                    else if(input == rand_num)
                    {
                        Console.WriteLine(name + " You won");
                        break;
                    }
                }
            }
            if(level == level3)
            {
                Console.WriteLine("You have 6 trials");
                Console.WriteLine("Guess a number between 1 to 50");

                for(int i = 0; i < 6; i++)
                {
                    int input = 0;
                    int rand_num = new Random().Next(1,50);
                    Console.Write("Enter a guess: ");
                    input = int.Parse(Console.ReadLine());

                    if(input != rand_num)
                    {
                        Console.WriteLine("Please try again");
                    }
                    else if(input == rand_num)
                    {
                        Console.WriteLine(name + " You won");
                        break;
                    }
                }
            }
       }
    }
}
