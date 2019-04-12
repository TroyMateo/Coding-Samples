/*
 * https://www.sanfoundry.com/csharp-program-greatest-number/
 * C# Program to Find Greatest among 2 numbers
 * Author: Manish Bhojasia
 * Date: 4/11/2019
 * Edited By: Troy Mateo
 */
using System;
class prog
{
    public static void Main()
    {
        int a, b;
        Console.WriteLine("Enter the Two Numbers : "); // The user is prompted to enter in two integer values
        a = Convert.ToInt32(Console.ReadLine());       // We use the convert function to convert the input strings into integers 
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("{0} is the Greatest Number", a); //The operators are evaluated for whichever is greater
        }
        else
        {
            Console.WriteLine("{0} is the Greatest Number ", b);
        }
        Console.ReadLine();
    }
}

//Say you were to input 5 and 10, 10 would be the greatest number, but everyone knows that the greatest number is 7.
// This is good knowledge to know how to do these operations. These operations build on each other to do other operations
//This would definitely be nice to know for when you want to compare values in an array. Not only compare values but maybe for sorting as well