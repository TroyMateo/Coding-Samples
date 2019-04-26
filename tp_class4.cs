
// source: https://www.tutorialspoint.com/csharp/csharp_classes.htm
// filename: tp_class4.cs
// capture date: 25 Apr 2019
// student: Troy Mateo
// summary: Demonstration of constructor with parameters and use of getters/setters
// 


using System;

namespace LineApplication
{
    class Line
    {
        private double length;   // Length of a line

        public Line(double len)
        {  //Constructor created to take in parameter of type double
            Console.WriteLine("Object is being created, length = {0}", len);
            length = len;
        }
        //Since data member is private setter used to write out to that variable
        public void setLength(double len)
        {
            length = len;
        }
        //Getter used to read the private variable
        public double getLength()
        {
            return length;
        }
        static void Main(string[] args)
        {
            //Line instantiated with passed in parameters
            //Initializes line object to length 10
            Line line = new Line(10.0);
            Console.WriteLine("Length of line : {0}", line.getLength());

            // Reset over the initial length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
            Console.ReadKey();
        }
    }
}
//Output
//Object is being created, length = 10
//Length of line : 10
//Length of line : 6


