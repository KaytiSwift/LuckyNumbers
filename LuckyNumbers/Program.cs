using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{//namespace
    class Program
    {//class
        static void Main(string[] args)
        {//main
            bool redo = true;
            do
            {
                //Asks the user for a min and max number for the random number generator
                Console.WriteLine("Please enter a minimum number.");
                int min = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a maximum number.");
                int max = int.Parse(Console.ReadLine());

                //Asks the user for 6 numbers they think will match the random numbers generated
                Console.WriteLine("Please enter 6 numbers you think will match the Lucky Numbers.");
                
                //array for the user numbers
                int[] userNums = new int[6];

                //loop that adds user input to the userNums array, checks for duplicates and checks for numbers outside the min and max range
                for (int i = 0; i < userNums.Length; i++)
                {
                    Console.WriteLine("Please enter a number.");
                    int input = int.Parse(Console.ReadLine());
                    if ((userNums.Contains(input) == false) && (input >= min) && (input <= max))
                    {
                        userNums[i] = input;
                    }
                    else if (userNums.Contains(input)== true)
                    {
                        Console.WriteLine("You already guessed that number. Please try again.");
                        i--;
                    }
                    else if ((input < min) || (input > max))
                    {
                        Console.WriteLine("Please enter a valid number within your minimum and maximum number range.");
                        i--;
                    }
                }

                //creates a new int array with 6 elements
                int[] luckyNums = new int[6];

                //instantiates an instance of the Random class called rand
                Random rand = new Random();

                //lucky number generator that checks for duplicates, checks guessed numbers for matches to lucky numbers, and assigns to luckyNums array
                int guesses = 0;
                for (int i = 0; i < luckyNums.Length; i++)
                {
                    int index = rand.Next(min, max);
                    
                    if (luckyNums.Contains(index) == false)
                    {
                        luckyNums[i] = index;
                        if (userNums.Contains(index))
                        {
                            guesses++;
                        }
                    }
                    else
                    {
                        i--;
                    }
                }

                //displays the lucky numbers to the user
                Console.WriteLine("You're lucky numbers are:");
                foreach (int num in luckyNums)
                {
                    Console.WriteLine("Lucky Number: " + num);
                }
                
                //displays to the user the number of numbers they guessed correctly
                Console.WriteLine("You have guessed {0} numbers correctly!", guesses);

                //calculates winnings and displays to the user the amount they have won from the jackpot
                double jackpot = 2000000;
                double winnings = jackpot / guesses;

                Console.WriteLine("You have won ${0}!", winnings);

                //asks the user if they want to play again or quit and exits if they want to quit
                Console.WriteLine("Do you want to play again? Enter yes or no.");
                string response = Console.ReadLine().ToLower();

                if (response == "no")
                {
                    redo = false;
                }

            } while (redo == true);
        }//main
    }//class
}//namespace
