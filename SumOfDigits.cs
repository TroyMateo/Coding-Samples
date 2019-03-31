/*Taken from Sanfoundry.com
 * 03/31/2019
 * C# Program to Get a Number and Display the Sum of the Digits 
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
            int num, sum = 0, r; //Here we are initializing our integer variables
            Console.WriteLine("Enter a Number : "); //The user is prompted for an input 
            num = int.Parse(Console.ReadLine()); //User inputs the value they want to get the sum of
            while (num != 0) 
            {
                r = num % 10; // Modulus operation to get the remainder of the value
                num = num / 10; // Integer division is performed to get new num value
                sum = sum + r; // Value is equal to sum plus the remainder
                               // Loop continues as long as the num value does not equal to 0
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();
             // Example if we had input value of 13, 13 != 0 so we go through the loop
             //13 % 10 = 3 
             // num = 13 /10 which makes new num = 1 due to integer division
             // sum = 0 + 3 which makes our new sum = 3
             // 1 != 0 so loops again, 1 % 10 = 1. 1 is our new remainder
             // sum = 3 + 1 <-- new remainder value. sum is now 4
             // num = 1 / 10 integer division equates to 0
             // num == 0 so loop condition is now false. We break out of the while loop.
             // sum of the two digits in 13 = 1 + 3 is 4
        }
    }
}