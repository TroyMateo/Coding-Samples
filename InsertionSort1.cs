/*https://www.sanfoundry.com/csharp-program-insertion-sort/
 * Author: Manish Bhojasia
 * Date: 4/30/19
 * C# Program to Perform Insertion Sort
 * Edited By: Troy Mateo
 * Refactored to make cleaner code
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializes an array of integers with five elements
            int[] arr = new int[] { 83, 12, 3, 34, 60 };
            int i;
            //Displays the unsorted array
            Console.WriteLine("The Array is :");
            for (i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            //Calls the insertsort method
            insertsort(arr);
            Console.WriteLine("The Sorted Array is :");
            for (i = 0; i < 5; i++)
                Console.Write(arr[i] + " ");
            Console.ReadLine();
        }
        static void insertsort(int[] data)
        {
            int i, j;
            for (i = 1; i < data.Length; i++)
            {
                int item = data[i]; //This is the unsorted element
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    //If statement goes through and shifts sorted elements to the right creating a position for the unsorted element
                    //once all elements are in place else statement changes ins =1 to break out of the for loop
                    if (item < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
        }
    }
}

//Output
