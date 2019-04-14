/*https://www.dotnetperls.com/parse
 * Author: Sam Allen
 * Date: 04/13/19
 * Edited By: Troy Mateo
 * Program designed to demonstrate explicit conversion from one base type to another
 */
using System;

class Program
{
    static void Main()
    {
        // Convert string to number.
        string text = "500";
        //int.parse is the method we call to have an explict conversion from a string to an integer
        int num = int.Parse(text);
        Console.WriteLine(num);

        // I added these variables here to demonstrate the explicit conversion the other way around from int to a string
        int num2 = 700;
        string text2 = num2.ToString();
        Console.WriteLine(text2);

        //int.Parse can throw an exception so I added a demonstration of int.TryParse() method which acts as a try catch block and a conversion
        //function all in one. This first one is to demonstrate a successful run at the TryParse
        int num3;
        string text3 = "900";
        if (int.TryParse(text3, out num3)){
            Console.WriteLine(num3);
        }
        else
        {
            Console.WriteLine("Sorry, not a valid integer");
        }

        //This second one to demonstrate an unsuccessful TryParse which the bool value avluates to false so we let the user know that
        //the attempt was unsuccessful 
        int num4;
        string text4 = "a";
        if (int.TryParse(text4, out num4))
        {
            Console.WriteLine(num4);
        }
        else
        {
            Console.WriteLine("Sorry, not a valid integer");
        }
    }
}

// Output 500, 700, 900, and "Sorry, not a valid integer"