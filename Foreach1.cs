/*Author: Troy Mateo
 * Inspiration from: https://www.geeksforgeeks.org/c-sharp-foreach-loop/
 * Date: 06 May 2019
 * C# program demonstrating use of foreach loop
 */
using System;
using System.Collections;

namespace Foreach1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the elements in the array: ");

            //Creates an array of strings initialized with string variables of names
            string[] arr = new string[] { "Bill", "Lucy", "Sarah", "Tom" };

            //Foreach loop iterates through the string[] arr foreach variable name of type string
            //instead of iterating through indexers like a for loop or using counters
            //foreach is used as in the name states for each element in the collection
            foreach (string name in arr)
            {
                Console.WriteLine(name);
            }
        }
            
    }
}

//Output
//Print out the elements in the array:
//Bill
//Lucy
//Sarah
//Tom
