/*Created by: Troy Mateo
 * Date: 05 May 2019
 * C# Program splitting strings
 */
using System;

namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declared a string with value
            string str = "Sometimes there are strings that may need splitting";

            //Printed string pre split
            Console.WriteLine(str);

            //Split string up by space delimeter and stored values in an Array of strings
            string[] strArr = str.Split(' ');

            //Iterated through the string array to print out individual string elements
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine("Split word: {0}", strArr[i]);
            }
        }
    }
}

//Output
//Sometimes there are strings that may need splitting
//Split word: Sometimes
//Split word: there
//Split word: are
//Split word: strings
//Split word: that
//Split word: may
//Split word: need
//Split word: splitting
