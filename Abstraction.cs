
/*https://www.geeksforgeeks.org/c-sharp-abstraction/
 * Author: Ankita Saini
 * Date: 4/24/19
 * Edited By: Troy Mateo
 */
// C# program to calculate the area  
// of a square using the concept of 
// data abstraction 
using System;

namespace Demoabstraction
{

    // abstract class 
    abstract class Shape
    {

        // abstract method 
        public abstract int area();
    }

    // square class inherting 
    // the Shape class 
    class Square : Shape
    {

        // private data member 
        private int side;

        // method of  square class 
        public Square(int x = 0)
        {
            side = x;
        }

        // overriding of the abstract method of Shape 
        // class using the override keyword 
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
    //Adding abstract class that is implicitly abstract
class Circle: Shape
    {
        //private data member
        private int circumference;

        public Circle(int x)
        {
            circumference = x;
        }
        //Area class is inherited but not implemented making it so circle is implicitly abstract
        public override int area()
        {
            throw new NotImplementedException();
        }

    }
    // Driver Class 
    class GFG
    {

        // Main Method 
        static void Main(string[] args)
        {

            // creating reference of Shape class 
            // which refer to Square class instance 
            Shape sh = new Square(4);

            // calling the method 
            double result = sh.area();

            Console.WriteLine("{0}", result);

            Circle cr = new Circle(5);

            double result2 = cr.area();

            Console.WriteLine("Area of circle is: " + result2);

        }
    }
}

//Output area of square is 16
//Circle is abstract since it did not implement area method from the shape abstract class
