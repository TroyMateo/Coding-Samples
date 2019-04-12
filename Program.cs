/*
 * https://www.sanfoundry.com/csharp-program-single-inheritance/
 *  C# Program to Illustrate Single Inheritance
 *  Author:Manish Bhojasia
 *  Date: 4/11/2019
 *  Edited by: Troy Mateo
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
            Student s = new Student();
            s.Learn();
            s.Teach();
            Console.ReadKey();
        }
        class Teacher
        {
            public void Teach()
            {
                Console.WriteLine("Teach");
            }
        }
        class Student : Teacher
        {
            public void Learn()
            {
                Console.WriteLine("Learn");
            }
        }
    }
}