using System;

namespace guessingGameMethod
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Choose a Level between Easy, Intermediate and Hard, 1 for Easy, 2 for Intermediate and 3 for Hard");
             string level;
            
                Random random = new Random();
                Console.Write("What level would you like to play: ");
                var levelChose = int.Parse(Console.ReadLine());
 
                if (levelChose == 1)
                {
                    level = "Easy";
                }
                else if (levelChose == 2)
                {
                    level = "Intermediate";
                }
                else if (levelChose == 3)
                {
                    level = "Hard";
                }
                else
                {
                    level = "";
                }
 
                //If user chose Easy
                if (level == "Easy")
                {
                    GuessingGame(1, 10,6);
                }

                if (level == "Intermediate")
                {
                    GuessingGame(1, 20, 4);
                }

                if (level == "Hard")
                {
                    GuessingGame(1,50, 3);
                }

        }

        static void GuessingGame(int min,  int max, int attempts)
        {
            Console.WriteLine($"Please Take a Guess between {min} and {max}, You have {attempts} trials");

            Random random = new Random();
            int guess = random.Next(1,11);

            int trials = 1;

            Console.Write("Guess a number now: ");
            int GamerGuess = int.Parse(Console.ReadLine());
                    
                    do
                    {
                        if (trials == attempts)
                        {
                            Console.WriteLine("Sorry, You Lose");   
                            break;
                        }
 
                        if (guess != GamerGuess)
                        {
                            Console.Write("Sorry, wrong number, Play try again: ");
                            GamerGuess = int.Parse(Console.ReadLine());
                            trials++;
                        }
                        
                        if (guess == GamerGuess)
                        {
                            Console.WriteLine($"Hey, You won. The number was {guess}");
                            break;
                        }
                        
                    }while(guess != GamerGuess);
               }
    }
}
    
                    
