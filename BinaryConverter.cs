/*Created by: Troy Mateo
 * Inspiration from: Harold's class on binary numbers
 * Date: 05 May 2019
 * Program designed to convert numbers into binary
 */
using System;
using System.Collections.Generic;

namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var quotientValues = new List<int>();
            var remainderValues = new List<int>();

            Console.WriteLine("Please enter value to be converted: ");

           int num = int.Parse(Console.ReadLine()); // User inputs number to be converted here

            while (num > 0)
            {
                quotientValues.Add(num);
                num = num / 2; 
            }
            for (int i = 0; i < quotientValues.Count; i++) // This allows user to see the quotient values of number as you go down
            {
                Console.WriteLine("Quotient values: " + quotientValues[i]);
            }
            for ( int i = 0; i < quotientValues.Count; i++) //This for loop records the remainders from the division functions for  end binary results
            {
                remainderValues.Add(quotientValues[i] % 2);
            }

            Console.WriteLine("Your binary value: ");

            for (int i = remainderValues.Count - 1; i >= 0; i--) // Starting index is the size of the list -1 or else you'll be out of bounds. Also 0 is an index
            {
                Console.Write(remainderValues[i]);
            }
            Console.ReadLine(); // So the program doesn't shut down upon completion
        }
    }
}