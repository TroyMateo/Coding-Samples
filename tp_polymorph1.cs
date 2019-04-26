// source: https://www.tutorialspoint.com/csharp/csharp_polymorphism.htm
// filename: tp_polymorph1.cs
// capture date: 26 Apr 2019
// student: Troy Mateo
// summary: C# program demonstrating use of polymorphism
// 


using System;

namespace PolymorphismApplication
{
    class Printdata
    {
        //Set of methods all with the name Print but take a different parameter types
        //This is polymorphism same name but different functions
        void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
        static void Main(string[] args)
        {
            Printdata p = new Printdata();

            // Call print to print integer
            p.print(5);

            // Call print to print float
            p.print(500.263);

            // Call print to print string
            p.print("Hello C#");
            Console.ReadKey();
        }
    }
}

//Output
//Printing int: 5
//Printing float: 500.263
//Printing string: Hello C#
