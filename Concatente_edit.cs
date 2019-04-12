/*
 * https://www.sanfoundry.com/csharp-program-concatenate-strings/
 * Author: Manish Bhojasia
 * C# Program to Concatenate Two Strings
 * Edited by: Troy Mateo
 */
/* 1) I took out the string variable s3 and wrote out to the line both s1 and s2 with a " " in the middle to look nicer
* 2) A better way to concatenate strings especially if you have many strings to put together could be use of a string builder
*/
using System;
class Program
{
    static void Main()
    {
        string s1 = "Good"; //The concept of concatenating is to stick two of the string variables together
        string s2 = "Morning"; //Concatenating can be used for hard coded strings, or even different variable types like an integer could be 
                                // printed out as a string.
        Console.WriteLine(s1 + " " + s2); // If you don't include the + " " +, the two strings would be stuck together without a space
        Console.ReadLine();
    }
}
//Output turns out to be Good Morning instead of the previous GoodMorning. 
