using System;

namespace Loops_Bruner_Zach
{
        class Program
    {
        static void Main(string[] args)
        {
            // Ask the user wgy do you want to make the games
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();
            // Counts number of spaces in a sentence
            Console.WriteLine($"The sentence,\"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");
            // Enter a whole number to get the sum of the number
            Console.WriteLine("Please enter a whole number!");
            string response2 = Console.ReadLine();
           // Shows sum of indivdual digits
            Console.WriteLine($"The sum of the indivdual digits of {response2} is {SumOfDigits(response2)}!");
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces in</param>
        /// <returns>Number of spaces in the sentence </returns>
        static int CountNumberOfSpaces(string sentence)
        {
              int numberofSpaces = 0;
            foreach (char character in sentence)
            {
                if (character == ' ')
                numberofSpaces++;
                
            }  
            return numberofSpaces;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">Shows the sum of the digits of a whole number</param>
        /// <returns> tells the user the numeric number</returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                sum += (int) Char.GetNumericValue(digit);
            }
            return sum;
        }
    }
}
