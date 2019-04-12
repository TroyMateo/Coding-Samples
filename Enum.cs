/*https://www.dotnetperls.com/enum
 * Author: Sam Allen
 * Date: 04/12/2019
 * Edited By: Troy Mateo
 * This is a c# program demonstrating the use of enums
 * 
 * 1) I added the value2 and value3 variables and printed them out at the end to demonstrate the 
 * the underlying integer value for enums
 */

using System;

class Program
{
    // This is the list of enum variables created all with their inherit integer values.
    enum Importance
    {
        None,
        Trivial,
        Regular,
        Important,
        Critical
    }

    static void Main()
    {
        // ... An enum local variable.
        Importance value = Importance.Critical;

        // ... Test against known Importance values.
        if (value == Importance.Trivial)
        {
            Console.WriteLine("Not true");
        }
        else if (value == Importance.Critical)
        {
            Console.WriteLine("True");
        }

        int value2 = (int)Importance.Regular;
        int value3 = (int)Importance.Critical;

        Console.WriteLine(value2);
        Console.WriteLine(value3);

    }
}

//Output would be true, 2, 4.
