/*Created by: Troy Mateo
 * Date: 05 May 2019
 * C# program to remove duplicates in a list
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Distinction1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a list of integers and fill it with elements to include duplicates

            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(4);
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);

            //Display the list before removal of duplicates
            Console.Write("List before removing duplicates: ");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write(" " + intList[i]);
            }

            Console.WriteLine();

            //Instantiate a new list of integers and assign the old list with duplicates removed
            //ToDistinct removes the duplicates but casts the list into IEnumarables
            //ToList() cast the IEnumarable back into a list
            List<int> intList2 = intList.Distinct().ToList();

            //Display the list with the duplciates removed
            Console.Write("List after removing duplicates: ");

            for (int j = 0; j < intList2.Count; j++)
            {
                Console.Write(" " + intList2[j]);
            }
            Console.Read();
        }
    }
}
//Output
//List before removing duplicates:  1 2 2 3 4 4 5 5 5
//List after removing duplicates:  1 2 3 4 5
