using System;
using System.Collections.Generic;
using System.Linq;

namespace HowManyNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many negative numbers in the list? \n" +
                "Enter up to 20 positive or negative numbers.\n" +
                "Hit enter when finished.\n");

            //initialize int list for all numbers
            List<int> numbers = new List<int>();

            //create loop for user to enter up to 20 numbers into list
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Enter value {0}: ", i + 1);
                string numberString = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(numberString))
                    break;

                int number = int.Parse(numberString);
                numbers.Add(number);

            }

            //initiate list for negative numbers only
            List<int> negativeNumbers = new List<int>();

            //create loop to loop through first list of 
            //numbers, determine if each is positive or negative, 
            //and add the negative numbers only to negativeNumbers list.
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    negativeNumbers.Add(number);
                }

                else continue;
            }

            //create variable for length of list of all numbers to use in method
            int numberCount = numbers.Count();

            //create variable for length of list of only negative numbers to use in method
            int numberCountNeg = negativeNumbers.Count();

            //print return strings from both methods to console
            Console.WriteLine();
            Console.WriteLine(NumberGrammar(numberCount));
            Console.WriteLine();
            Console.WriteLine(NumberGrammarNeg(numberCountNeg));

            Console.ReadKey();

        }

        //methods to use proper pluralization of the word number(s) when printing output to console.

        /// <summary>
        /// use singular number if total number count is 1, numbers if it is anything else.
        /// </summary>
        /// <param name="numberCount"></param>
        /// <returns>string with list count and proper pluralization</returns>
        private static string NumberGrammar(int numberCount)
        {
            if (numberCount == 1)
                return $"You entered {numberCount} number. ";
            else
                return $"You entered {numberCount} numbers. ";
        }
        
        /// <summary>
        /// use singular number of total number count of negative numbers list is 1, plural if anything else
        /// </summary>
        /// <param name="numberCountNeg"></param>
        /// <returns>string with list count and proper pluralization</returns>
        private static string NumberGrammarNeg(int numberCountNeg)
        {
            if (numberCountNeg == 1)
                return $"You entered {numberCountNeg} negative number. ";
            else
                return $"You entered {numberCountNeg} negative numbers. ";
        }

    }
}
