// C# program to illustrate the interface
/*https://www.geeksforgeeks.org/c-sharp-interface/
 * Auther: Mithun Kumar
 * Date: 4/24/19
 * Edited By: Troy Mateo
 * I added new interface Aesthetics and implemented its methods in the classes
 */
using System;

// interface declaration 
interface Vehicle
{

    // all are the abstract methods. 
    void changeGear(int a);
    void speedUp(int a);
    void applyBrakes(int a);
}

// class implements interface 
class Bicycle : Vehicle, Aesthetics
{
    string color;
    int speed;
    int gear;

    //Add color from newly created interface
    public void paintjob(string newColor)
    {
        color = newColor;
    }

    // to change gear 
    public void changeGear(int newGear)
    {

        gear = newGear;
    }

    // to increase speed 
    public void speedUp(int increment)
    {

        speed = speed + increment;
    }

    // to decrease speed 
    public void applyBrakes(int decrement)
    {

        speed = speed - decrement;
    }

    public void printStates()
    {
        Console.WriteLine("color: " + color +
                          " speed: " + speed +
                          " gear: " + gear);
    }
}

// class implements interface 
class Bike : Vehicle, Aesthetics
{
    string color;
    int speed;
    int gear;

    //Implement from Aesthetics interface
    public void paintjob(string newColor)
    {
        color = newColor;
    }
    // to change gear 
    public void changeGear(int newGear)
    {

        gear = newGear;
    }

    // to increase speed 
    public void speedUp(int increment)
    {

        speed = speed + increment;
    }

    // to decrease speed 
    public void applyBrakes(int decrement)
    {

        speed = speed - decrement;
    }

    public void printStates()
    {
        Console.WriteLine("color: " + color +
                          " speed: " + speed +
                          " gear: " + gear);
    }

}
//I added new interface to demonstrate that classes can inherit from multiple interfaces
interface Aesthetics
{
   void paintjob(string color);
}

class GFG
{

    // Main Method 
    public static void Main(String[] args)
    {

        // creating an instance of Bicycle  
        // doing some operations  
        Bicycle bicycle = new Bicycle();
        bicycle.paintjob("Red");
        bicycle.changeGear(2);
        bicycle.speedUp(3);
        bicycle.applyBrakes(1);

        Console.WriteLine("Bicycle present state :");
        bicycle.printStates();

        // creating instance of bike. 
        Bike bike = new Bike();
        bike.paintjob("Black");
        bike.changeGear(1);
        bike.speedUp(4);
        bike.applyBrakes(3);

        Console.WriteLine("Bike present state :");
        bike.printStates();
    }
}

//Output
//Bicycle present state :
//color: Red speed: 2 gear: 2
//Bike present state :
//color: Black speed: 1 gear: 1