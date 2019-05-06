/* C# program to illustrate the use of  
*'virtual' and 'override' modifiers
* https://www.geeksforgeeks.org/c-sharp-method-overriding/
* Author: SoM15242
* Date: 06 May 2019
* Edited By: Troy Mateo
*/
using System;

class baseClass
{

    // show() is 'virtual' here inviting user to override the method when it comes time in the derived class
    public virtual void show()
    {
        Console.WriteLine("Base class");
    }
}


//derived class inherits properties and methods from baseclass
class derived : baseClass
{

    //'show() method that showed virtual previously in the base class is now overridden
    //Overridden methods provide same method signatures but different behaviors
    //This helps to extend functionality for the derived class
    public override void show()
    {
        Console.WriteLine("Derived class");
    }
}

class GFG
{

    // Main Method to test out the overridden methods
    public static void Main()
    {

        baseClass obj;

        //object of the base class is instantiated to test out baseclass method
        obj = new baseClass();

        //baseclass object utilizes baseclass method
        obj.show();


        //derived class object is instantiated
        obj = new derived();

       //derived class object calls on the same method but the one used is the one ovveridden in the derived class
        obj.show();

    }
}

//Output
//Base class
//Derived class