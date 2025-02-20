using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объект класса random
            Random rnd = new Random();
            int RandomNumber = rnd.Next(1, 11);
            ConsoleKeyInfo attempt;
            int max = 0;
            int min = 0;
            int games = 0;
            int tryes = 0;
            do
            {   games++1;
                int currentTryes = 0;
                while (true)
                {
                    tryes++1;
                    int result = 0;
                    Console.WriteLine("Enter desired number in [1;100]");
                    while (!int.TryParse(Console.ReadLine(), out result) || (result > 11 || result < 1))
                        Console.WriteLine("Error. Enter correct number in [1;100]");
                    if (result > RandomNumber)
                        Console.WriteLine("Desired number less");
                    else if (result < RandomNumber)
                        Console.WriteLine("Desired number more");
                    else
                    {
                        Console.WriteLine("You win");
                        break;
                    }

                    
                    
                }
                tryes += currentTryes;
                max = max < currentTryes ? currentTryes : max;
                if (min == 0 || min > currentTryes) min = currentTryes;
                Console.WriteLine("Do you want play again? Enter y/n");
                //Console.WriteLine();
                attempt = Console.ReadKey();
            }   while (attempt.Key == ConsoleKey.Y);
            Console.WriteLine($"Max = {max}. \n Min = {min}.\n Average = {tryes/games}.");
        }
    }
}
