// source: https://www.tutorialspoint.com/csharp/csharp_inheritance.htm
// filename: tp_inheritance3.cs
// capture date: 26 Apr 2019
// student: Troy Mateo
// summary: C# program demonstrating principle of inheriting from one class but multiple interfaces
// 


using System;

namespace InheritanceApplication
{
    //Base class is definied with proteted data members and setters to manipulate those members
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // Interface PaintCost with one method that takes an integer variable area as a parameter
    public interface PaintCost
    {
        int getCost(int area);
    }

    // Derived class inherites from the base class Shape and the interface PaintCost
    //This is an example of multiple inheritance
    class Rectangle : Shape, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        //Since this method is from the PaintCost interface it MUST be implemented
        public int getCost(int area)
        {
            return area * 70;
        }
    }
    //Class used to test out the derived class
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            int area;

            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.WriteLine("Total paint cost: ${0}", Rect.getCost(area));
            Console.ReadKey();
        }
    }
}

//Output
//Total area: 35
//Total paint cost: $2450