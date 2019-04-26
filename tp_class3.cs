
// source: https://www.tutorialspoint.com/csharp/csharp_classes.htm
// filename: tp_class3.cs
// capture date: 25 Apr 2019
// student: Troy Mateo
// summary: Prorgam demonstrating more class functions
// 


using System;

namespace LineApplication
{
    // Here we define class Line, its data members and its methods
    class Line
    {
        private double length;   // Length of a line also accessor set to private

        //Constructor of the Line class will also display message when object is created
        public Line()
        {
            Console.WriteLine("Object is being created");
        }
        //A setter so the user can set the length of the line
        public void setLength(double len)
        {
            length = len;
        }
        //A getter so we can actually read what the length is
        public double getLength()
        {
            return length;
        }

        //Class to test out the line object
        static void Main(string[] args)
        {
            Line line = new Line();

            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
            Console.ReadKey();
        }
    }
}

//Output
//Object is being created
//Length of line : 6
