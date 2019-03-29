/* Program taken from sanfoundry.com
 * 03/28/2019
 * C# Program to Check whether the Entered Number is Even or Odd
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace check1
{
    class Program
    {
        static void Main(string[] args) //Here we have the main function call which serves as the starting point for any program
        {           
            Console.Write("Enter a Number : "); //We've declared variable i to be an integer and are asking the user for the value they want to test
            int i = int.Parse(Console.ReadLine()); //We are taking the user input from the keyboard and are using the int.Parse to convert the string into 
            if (i % 2 == 0) // an integer. In line 19 we see the use of two helpful operations.
            {
                Console.Write("Entered Number is an Even Number"); // Overall we have the if statements to evaluate the conditions in the parameters
                Console.Read(); // to be true of false. The condition checks to see if the inputted value is even or odd using the modulo operator.
            }                   //Modulus operator is nice because if your remainder is 0 its even. Any remainder means the value is odd
            else                // If statement is evaluated. If the statement is true we print out to the screen the first message stating it is even
                                //Otherwise the condition is false meaing that the inputted value is odd.
            {
                Console.Write("Entered Number is an Odd Number"); // One of the changes I made was instead of declaring the int i variable 
                Console.Read(); // on its own then assigning, I put it all on one line
            }
        }
    }
}