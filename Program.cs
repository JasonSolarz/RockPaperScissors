using System;
using System.Threading;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock Paper Scissors Game!\n\n");
            Console.Title = "Rock Paper Scissors";

            Random rand = new Random();

            var userInput = 0;
            var aiChoice = 0;

            Console.WriteLine("Choose your tool ->");
            Console.WriteLine("1 - Rock\n2 - Paper\n3 - Scissors");
            Console.Write(": ");

            userInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n1");
            Thread.Sleep(1000);
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("3");
            Thread.Sleep(1000);
            Console.WriteLine("   GO!\n\n");

            Console.WriteLine("and the winner is....\n\n");
            Thread.Sleep(1000);

            aiChoice = rand.Next(1, 4);

            //Calculate the results. Rock > Scissors, Scissors > Paper, Paper > Rock
            //Rock = 1
            //Paper = 2
            //Scissors = 3

            if(userInput == 1)
            {
                if(aiChoice == 3)
                {
                    Console.WriteLine("Rock Beats Scissors! \nPlayer wins!");
                }
                else if(aiChoice == 2)
                {
                    Console.WriteLine("Paper Beats Rock! \nComputer wins!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }
            else if(userInput == 2)
            {
                if(aiChoice == 1)
                {
                    Console.WriteLine("Paper Beats Rock! \nPlayer wins!");
                }
                else if(aiChoice == 2)
                {
                    Console.WriteLine("Scissors Beats Paper! \nComputer wins!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }
            else if(userInput == 3)
            {
                if(aiChoice == 2)
                {
                    Console.WriteLine("Scissors Beats Paper! \nPlayer wins!");
                }
                else if(aiChoice == 1)
                {
                    Console.WriteLine("Rock Beats Paper! \nComputer wins!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again");
            }

        }
    }
}
