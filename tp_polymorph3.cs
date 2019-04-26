
// source: https://www.tutorialspoint.com/csharp/csharp_polymorphism.htm
// filename: tp_polymorph3.cs
// capture date: 26 Apr 2019
// student: Troy Mateo
// summary: Demo of polymorph with multiple classes
// 


using System;

namespace PolymorphismApplication
{
    //Base class defining the data members and methods of shape
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        //Virtual keyword inviting derive classes to come and override the method
        public virtual int area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }
    //Derived rectangle class inheriting from base shape class
    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        //Rectangle class makes its own implementation of the base int area method
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }
    //Triangle classs doing the same thing as square class
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        //Triangle class providing another implementation of the base class's int area method
        public override int area()
        {
            Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }
    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
    class Tester
    {
        //Tester class tests out all the different implementations of the int area classes
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);

            c.CallArea(r);
            c.CallArea(t);
            Console.ReadKey();
        }
    }
}

//Output
//Rectangle class area :
//Area: 70
//Triangle class area :
//Area: 25


