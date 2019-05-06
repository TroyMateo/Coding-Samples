/*Created by: Troy Mateo
 * Date: 06 May 2019
 * C# program demonstrating use of overloading methods
 */
using System;
using System.Text;

namespace Overload1
{
    class Program
    {
        //Main method to test out the overloaded methods on program object
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Add(2, 4, 6);
            prog.Add("So", " much", " swag");
        }
        //Print method that takes in an integer parameter
        public void Print(int x)
        {
            Console.WriteLine(x);
        }
        //Same method name print different signature because it takes in string parameter instead
        public void Print(string y)
        {
            Console.WriteLine(y);
        }

        //Add method adding together integers from the parameter and calls the print method to print out result
        public void Add (int a, int b, int c)
        {
            int sum = a + b + c;
            Print(sum);
        }

        //Add method that takes in string parameters and appends strings using the stringbuilder object
        //stringbuilder object is then casted back into a string and printed out calling the print method
        public void Add(string aa, string bb, string cc)
        {
            StringBuilder str = new StringBuilder(aa, 50);
            str.Append(bb);
            str.Append(cc);
            Print(str.ToString());
        }
    }
}

//Output
//12
//So much swag
