/*
 * https://www.sanfoundry.com/csharp-program-indexoutofrange-exception/
 * C# Program to Demonstrate IndexOutOfRange Exception
 * Author: Manish Bhojasia
 * Edited by: Troy Mateo
 *
 * 1) Changes I made were to include a cacth block for general exceptions. Since exceptions are hierarchical it is just good practice
 * that if you do exception handling to include a general one for any exceptions that you may miss
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace differnce
{
    class arrayoutofindex
    {
        public void calculatedifference()
        {
            int difference = 0;
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
           //We surround the for loop in a try statement because we suspect that it may throw an exception
            try                                    
            {
                //The array itselsf has 5 elements meaning that the largest index you could go to would be 4
                //init <= 5 when checking the index violates that rule so it will throw an exception
                for (int init = 1; init <= 5; init++) 
                {
                    difference = difference - number[init];
                }
               //If the program worked correctly this would be the output
                Console.WriteLine("The difference of the array is:" + difference); 
            }
           //We have the catch block to let the user know what happened to cause the program not to function correctly
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class classmain
    {
        static void Main(string[] args)
        {
            arrayoutofindex obj = new arrayoutofindex(); //Where we get to put everything into action
            obj.calculatedifference();
            Console.ReadLine();
        }
    }
}

//Output is that the Index is out the bounds of the array
