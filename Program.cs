/* Code sample from sanfoundry.com
 * 03/29/2019
 * C# Program to Swap two Numbers
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp; //Here we are declaring three integer variables in one statement
            Console.Write("\nEnter the First Number : "); //The program prints this message to the console to prompt user for first value
            num1 = int.Parse(Console.ReadLine()); // We now assign and convert the value of the user input to the num1 integer value
            Console.Write("\nEnter the Second Number : "); //We do this again for the second number
            num2 = int.Parse(Console.ReadLine());
            temp = num1; //When we do temp and assign it to num1 we are actually making it so that they both point at the same location in memory
            num1 = num2; // temp is now pointing at num1 location and num1 now points at num2
            num2 = temp; //num2 now points at temp which is pointing at num1's original location in memory
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1); //Messages are printed out and we see that the numbers have swapped because of the 
            Console.Write("\nSecond Number : " + num2); //changes in memory location
            Console.Read(); //This is all helpful later on especially when you start to learn about sorting
        }
    }
}