/*https://www.dotnetperls.com/enum
 * Author: Sam Allen
 * Date: 04/12/2019
 * Edited By: Troy Mateo
 * This is a c# program demonstrating the use of enums
 */

using System;

class Program
{
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
    }
}