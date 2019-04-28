/*https://www.sanfoundry.com/csharp-program-bubble-sort/
 * Author: Manish Bhojasia
 * Date: 4/27/19
 * Edited By: Troy Mateo
 * C# Program to Perform Bubble Sort
 */
using System;

//Demonstrating the bubblesort
class bubblesort
{
    static void Main(string[] args)
    {
        //An array of integers a is initialized with five elements
        int[] a = { 3, 2, 5, 4, 1 };

        //int t defines the temporary value that will hold one of the elements that will be switching
        int t;
        Console.WriteLine("The Array is : ");

        //Displays the unsorted array
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }

        //Bubblesort iterates through bubbbling the largest value to the top and after it gets there it iterates through again
        // to the next largest integer
        for (int j = 0; j <= a.Length - 2; j++)
        {
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (a[i] > a[i + 1])
                {
                    t = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = t;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The Sorted Array :");
        foreach (int aray in a)
            Console.Write(aray + " ");
        Console.ReadLine();
    }
}

//Output
//The Array is :
//3 2 5 4 1
//The Sorted Array :
//1 2 3 4 5
