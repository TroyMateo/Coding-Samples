/*https://www.dotnetperls.com/palindrome
 * Author: Sam Allen
 * Date: 03 May 2019
 * C# program determining if a string is a palindrome
 * Edited By: Troy Mateo
 * Added boolean method to check if a string was null or empty
 * Added comments to describe what is going on in the program
 */
using System;


class Program
{
  //boolean method determining whether a string is a palindrome
    public static bool IsPalindrome(string value)
    {
        if (String.IsNullOrEmpty(value))
        {
            return false;
        }
        //This sets the lower index
        int min = 0;
        //Sets the upper index
        int max = value.Length - 1;
        while (true)
        {
            //If the lower is able to surpass the upper then the string is probably a palindrome
            if (min > max)
            {
                return true;
            }
            //character value set at the element of the string's lower index
            char a = value[min];
            //character value set at the element of the string's upper index
            char b = value[max];
            //ToLower method called to make sure character values are set to lowercase so they can be compared equally
            //If the values of the characters are not equivalent then the method returns false
            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            //Increment the min and decrement the max to shift the pointers and then compare the next values
            min++;
            max--;
        }
    }

    static void Main()
    {
        string[] array =
        {
            "civic",
            "deified",
            "deleveled",
            "devoved",
            "dewed",
            "Hannah",
            "kayak",
            "level",
            "madam",
            "racecar",
            "radar",
            "redder",
            "refer",
            "repaper",
            "reviver",
            "rotator",
            "rotor",
            "sagas",
            "solos",
            "sexes",
            "stats",
            "tenet",

            "Dot",
            "Net",
            "Perls",
            "Is",
            "Not",
            "A",
            "Palindrome",
            ""
        };

        //Prints the strings in the array and their palindrome evaluation
        foreach (string value in array)
        {
            Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
        }
    }
}

//Output
//Evereything up to tenet is true
//All strings after that are false except for " " which is true
//Empty strings in this program are considered palindromes