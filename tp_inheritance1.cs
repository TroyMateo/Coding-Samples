// source: https://www.tutorialspoint.com/csharp/csharp_inheritance.htm
// filename: tp_inheritance1.cs
// capture date: 26 Apr 2019
// student: Troy Mateo
// summary: Program demonstrating use of inheritance
// 


using System;

namespace InheritanceApplication
{
    //Definition for the base class shape
    class Shape
    {
        //Public accessors allow for derived class to call these methods
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        //Protected accessor also allowing derived class to inherit these data members
        protected int width;
        protected int height;
    }

    // Derived class inherits from base class shape
    class Rectangle : Shape
    {
        //No data members listed because they are already inherited from the shape class
        //New method getArea created extend functionality of original base class
        public int getArea()
        {
            return (width * height);
        }
    }
    class RectangleTester
    {
        static void Main(string[] args)
        {
            //Instantiation of derived class creating space in memory and giving back reference pointer to this object
            Rectangle Rect = new Rectangle();

            //Rectangle using setter methods from the base class to set the values of inherited data members
            Rect.setWidth(5);
            Rect.setHeight(7);

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}

//Output
//Total area: 35