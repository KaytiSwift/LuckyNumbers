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
                    if (userNums.Contains(input) == true)
                    {
                        Console.WriteLine("You already guessed that number. Please try again");
                        i--;                        
                    }
                    if ((input < min) || (input > max))
                    {
                        Console.WriteLine("Please enter a valid number within your minimum and maximum number range.");
                        i--;
                    }
                    userNums[i] = input;
                }

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
