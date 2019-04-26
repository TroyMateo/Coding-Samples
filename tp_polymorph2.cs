// source: https://www.tutorialspoint.com/csharp/csharp_polymorphism.htm
// filename: tp_polymorph2.cs
// capture date: 26 Apr 2019
// student: Troy Mateo
// summary: Demonstration of polymorphism using overridden methods instead of different method signatures
// 


using System;

namespace PolymorphismApplication
{
    //Abstract class that defines an abstract method area
    abstract class Shape
    {
        public abstract int area();
    }
    //Rectangle class that inherits the area method from base class Shape
    class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        //Implementing abstract method int area and implementing it. 
        //Uses keyword ovverride to change implementation of the int area method
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }
    //Rectangle tester to test out that the polymorphed method works
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
            Console.ReadKey();
        }
    }
}

//Output
//Rectangle class area :
//Area: 70

