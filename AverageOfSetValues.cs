/*https://www.sanfoundry.com/csharp-program-average-values/
 * C# Program to Compute Average for the Set of Values
 * 04/03/2019
 */
using System;
class program
{
    public static void Main()
    {
        //Here we are declaring a set of integers and some to be initialized
        int m, i, sum = 0, avg = 0;
        Console.WriteLine("Enter the size of the Array "); // Made change from "number of terms to size of for better readability"
        //The size of the array is then inputted by the user from the keyboard
        m = int.Parse(Console.ReadLine());  
        //An array of integers is now created
        int[] a = new int[m];
        Console.WriteLine("Enter the Array Elements ");
        //Using a for loop to iterate through the array and input values for each element
        for (i = 0; i < m; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        //Each element is iterated over and the values in those elements are then added up for a grand total
        for (i = 0; i < m; i++)
        {
            sum += a[i];
        }
        //Grand total is then divided by the size of the array or number of elemnts
        avg = sum / m;
        //Output results in the average of the set of values from the array
        Console.WriteLine("Average is {0}", avg);
        Console.ReadLine();
    }
}
