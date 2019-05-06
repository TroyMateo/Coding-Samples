/*https://www.sanfoundry.com/csharp-programs-generate-number-reverse/
 * C# Program to Get a Number and Display the Number with its Reverse
 * Author: Manish Bhojasia
 * Date: 06 May 2019
 * Edited By: Troy Mateo
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
            //Declares two integer variables
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            //An integer is input by the user and read into the program
            num = int.Parse(Console.ReadLine());
            //While number is not equivalent to 0 continue looping
            while (num != 0)
            {
                //intial run through reverse is going to equal 0
                reverse = reverse * 10;
                //Modulus operator by factor of 10 and add that to integer reverse
                reverse = reverse + num % 10;
                //Do integer division
                num = num / 10;
                //If there is still a number not equal to 0 iterate through again
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            Console.ReadLine();

        }
    }
}

//Output
//Sample input would be 25
//reverse is 0 + 25 % 10 = 5
//integer division 25 / 10 = 2
//2 != 0 so loop through again this time
//5 * 10 = 50
//5 + 2 % 10 = 52
//2 / 10 = 0
//loop is done and print reverse
//52