/*
 * https://www.sanfoundry.com/csharp-program-single-inheritance/
 *  C# Program to Illustrate Single Inheritance
 *  Author:Manish Bhojasia
 *  Date: 4/11/2019
 *  Edited by: Troy Mateo
 * 1) I included an attribute of type string labeled schoolPerson to show that derived classes inherit both behavior and attributes
 * 2) And I wanted to show how one could access these attributes and behaviors depending on the accessor modifier
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher d = new Teacher();
            d.Teach();
            Console.WriteLine(d.schoolPerson);
            Student s = new Student();
            s.Learn();
            s.Teach();
            Console.WriteLine(s.schoolPerson);
            Console.ReadKey();
            
            //Since Student s inherits from teacher it also has the ability to call the function Teach
        }
        // Teacher class is created as the super class
        class Teacher
        {
            public string schoolPerson = "I attend this school";
            public void Teach()
            {
                Console.WriteLine("Teach");
            }
        }
        //Student class inherits from Teacher
        class Student : Teacher
        {
            public void Learn()
            {
                Console.WriteLine("Learn");
            }
        }
    }
}
// Output is Teach
//I attend this school
//Learn
//Teach
//I attend this school
