/*Created the program
 * Author: Troy Mateo
 * Date: 05 May 2019
 * C# program showing how to find a missing element in an array
 */
using System;

namespace FindMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defines an array of integers and its elements
            int[] arr = new int[] {1, 2, 3, 4, 6, 7};

            Console.Write("Find the missing number in: ");

            //Prints out the array of integers
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();

            //Creates a product from the total indeces divided by two
            int total = (arr.Length + 1) * (arr.Length + 2) / 2;
            int missingNumber = total;

            //Subtracts the element value from the total retrieved earlier to give the missing number
            for (int j = 0; j < arr.Length; j++)
            {
                missingNumber -= arr[j];
            }

            Console.WriteLine("Missing number is: {0}", missingNumber);
        }
    }
}

//Output
//Find the missing number in:  1 2 3 4 6 7
//Missing number is: 5
