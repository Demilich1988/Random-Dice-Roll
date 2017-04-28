using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Dice_Roll
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //Calls Method to gather user Input
            int numberOfRolls = UserInput();

            //Calls Method to use user Input to roll 20 sided dice
            DiceRolls(numberOfRolls);

            
            
        }

        /// <summary>
        /// Calls random class and then rolls 30 sided dice and prints out each roll and total of all rolls
        /// Knows how many to roll based on user input already gathered. 
        /// </summary>
        /// <param name="numberOfRolls">Number times dice is rolled </param>
        private static void DiceRolls(int numberOfRolls)
        {
            int diceRoll = numberOfRolls;
            int total = 0;

            //Call Random class for dice rolls
            Random random = new Random();

            //For loop to go though until it reaches user selected number
            for (int i = 0; i < numberOfRolls; i++)
            {
                diceRoll = random.Next(20) + 1;
                total += diceRoll;
                //Print out number
                Console.WriteLine(diceRoll);
            }

            Console.WriteLine("The total is:" + total);

        }

        /// <summary>
        /// Asks user for input
        /// </summary>
        /// <returns>user input</returns>
        private static int UserInput()
        {
            int userInput;
            string consoleInput;

            //Ask user for input
            Console.WriteLine("Please enter a number or the word quit to eixt: ");
            consoleInput = Console.ReadLine();
            userInput = Convert.ToInt32(consoleInput);

            return userInput;
        }

      
    }
}
