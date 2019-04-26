
// source: https://www.tutorialspoint.com/csharp/csharp_classes.htm
// filename: tp_class5.cs
// capture date: 25 Apr 2019
// student: Troy Mateo
// summary: Program displaying use of destructor
// 


using System;

namespace LineApplication
{
    class Line
    {
        private double length;   // Length of a line

        public Line()
        {   // constructor
            Console.WriteLine("Object is being created");
        }
        //Destructor has no access modifier so can't be called on explicitly
        //Also garbage collector already does this automatically
        ~Line()
        {   //destructor
            Console.WriteLine("Object is being deleted");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
        static void Main(string[] args)
        {
            Line line = new Line();

            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
        }
    }
}
//Output
//Object is being created
//Length of line : 6