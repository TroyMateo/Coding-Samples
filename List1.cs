/*Created by: Troy Mateo
 * Date: 06 May 2019
 * C# program demonstrating use of list collection
 */

using System;
using System.Collections.Generic;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create some lists");

            //Instantiates two lists and second already initialized with variables
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int> { 1, 2, 3, 4 };

            //Adds elements into the first list
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);

            //Prints out count of both lists to display they are similar 
            Console.WriteLine("Display count of list1: {0} list2: {1}", list1.Count, list2.Count);

            Console.WriteLine("Print the first list");

            Console.Write("List1: ");

            //Loop operation to display all elements of the first list
            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Add to second list and print it out");

            //Adds elements to second list to demonstrate the flexibility of lists over traditional arrays
            //Even though list2 was initialized with variables you are able to add without having to copy over to a new collection
            list2.Add(5);
            list2.Add(6);

            Console.Write("List2: ");

            //Foreach displays the list2 with new elements
            foreach (int number in list2)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();


        }
    }
}

//Output
//Create some lists
//Display count of list1: 4 list2: 4
//Print the first list
//List1: 1 2 3 4
//Add to second list and print it out
//List2: 1 2 3 4 5 6
