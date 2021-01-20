using System;
using System.Collections.Generic;
using System.Linq;

namespace ResultRoaster
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int students = random.Next(200, 1000);

            List<int> scores = new List<int>();

            int pass = 0;
            int average = 0;
            int fail = 0;



            Console.WriteLine("Hello, This is the number of students who are in the class");


            for (int i = 0; i < students; i++)
            {
                int score = random.Next(1,101);
                scores.Add(score);
                
                if(score >= 70)
                {
                    pass = pass + 1;
                }
                else if (score>=50 && score < 70)
                {
                    average = average + 1;
                }
                else if(score < 50)
                {
                    fail = fail + 1;
                }
                


            }
             Console.WriteLine("Below are the number of students that took the exam"); 
            Console.WriteLine(students); 
            Console.WriteLine("Below are the number of students that passed the exam by getting a score of 70 and above");     
            Console.WriteLine(pass);
            Console.WriteLine("Below are the number of students who got the average score between 50-69"); 
            Console.WriteLine(average);
            Console.WriteLine("Below are the number of students who failed the exam by getting a score below 50"); 
            Console.WriteLine(fail);
            Console.WriteLine ("Below are the scores of all the students who took the exam");

            for (int i = 0; i <students; i++)
            {
                Console.WriteLine(scores[i]);
            }

        }
    }
}
