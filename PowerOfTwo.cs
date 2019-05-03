/* https://www.geeksforgeeks.org/program-to-find-whether-a-no-is-power-of-two/
 * C# program to find whether 
* a no is power of two
* Author: Sam007
* Date: 03 May 2019
* Edited By: Troy Mateo
*/
using System;

class GFG
{

   //Boolean function to check if a number is a power of 2
   //Function takes in an integer as a parameter
    static bool isPowerOfTwo(int n)
    {
        if (n == 0)
            return false;
        //1 would be our break because 2^0 is 1, but also wouldn't work for our modulus operator
        while (n != 1)
        {
            //If the result of this operation is anything other than 0 then it cannot be a power of 2
            if (n % 2 != 0)
                return false;
            //Divide the integer by 2 and keep checking
            n = n / 2;
        }
        //If the input integer survives then it must return true and is a power of 2
        return true;
    }

    // Driver program  
    public static void Main()
    {
        int x = 31;
        int y = 64;
        Console.WriteLine("Is " + x + " a power of 2?");
        Console.WriteLine(isPowerOfTwo(x) ? "Yes" : "No");
        Console.WriteLine("Is " + y + " a power of 2?");
        Console.WriteLine(isPowerOfTwo(y) ? "Yes" : "No");

    }
}

//Output
//Is 31 a power of 2?
//No
//Is 64 a power of 2?
//Yes