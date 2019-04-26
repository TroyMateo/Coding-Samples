
// source: https://www.tutorialspoint.com/csharp/csharp_inheritance.htm
// filename: tp_inheritance2.cs
// capture date: 26 Apr 2019
// student: Troy
// summary: Program to demonstrate extended functionality of base classes through derived classes
// 


using System;

namespace RectangleApplication
{
    class Rectangle
    {

        //member variables
        protected double length;
        protected double width;

        //Base constructor creates instance of base class with double parameters
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        //Method that calls on the initialized parameters and multiplies them together to get the area
        public double GetArea()
        {
            return length * width;
        }
        //Display methods shows what the individual values of the initialized data members are and the result of the getArea method
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle  
    //Tabletop class inherits all data members and methods from the Rectangle class
    class Tabletop : Rectangle
    {
        //Tabletop extends functionality of base class by adding new data member cost
        private double cost;
        //Tabletop constructor uses a static constructor to initilize any static variables to their default values
        public Tabletop(double l, double w) : base(l, w) { }
        //Method that will use the getArea method of the base class and multiply it to get the cost of the tabletop object
        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        //Rectangle display method calls on the base class display method and extends functionality by adding cost to the display
        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }
    //Rectangle class testing out the derived class and its functions
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
            Console.ReadLine();
        }
    }
}
//Output
//Length: 4.5
//Width: 7.5
//Area: 33.75
//Cost: 2362.5