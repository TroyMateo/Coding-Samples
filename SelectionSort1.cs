/*https://www.sanfoundry.com/csharp-program-selection-sort/
 * Author: Manish Bhojasia
 * Date: 4/28/19
 * Edited By: Troy Mateo
 * C# Program to Perform a Selection Sort
 * Refactored to make shorter code and get rid of unneccesary lines
 */
using System;
class Program
{
    static void Main(string[] args)
    {
        //New unsorted array of integers array is initialized with 10 elements
        int[] array = new int [] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
        Console.WriteLine("The Array Before Selection Sort is: ");

        //Displays the initial unsorted array to the console
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        //Declares two  variables a temporary integerer to hold variables that will be swithced
        //This is done by referencing the temporary to point to the same location as the variable that will be needed to switch
        int tmp, min_key;
        //Set of nested for loops with varaible j to determine the index that needs to be sorted
        //After that point the element at this index will be compared to all other elements at every other index to see which is greater or lower
        //After determining which element is the lowest the value at that index and the initial index is swapped
        //The lowest element is now at the beginning index and the the counter shifts the index over for the new iteration of sorting
        for (int j = 0; j < array.Length - 1; j++)
        {
            min_key = j;

            for (int k = j + 1; k < array.Length; k++)
            {
                if (array[k] < array[min_key])
                {
                    min_key = k;
                }
            }

            tmp = array[min_key];
            array[min_key] = array[j];
            array[j] = tmp;
        }
        Console.WriteLine();
        //The new sorted index is now displayed
        Console.WriteLine("The Array After Selection Sort is: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.ReadLine();
    }
}

//Output
//The Array Before Selection Sort is:
//100 50 20 40 10 60 80 70 90 30
//The Array After Selection Sort is:
//10 20 30 40 50 60 70 80 90 100

