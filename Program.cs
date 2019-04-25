/*https://www.geeksforgeeks.org/c-sharp-queue-class/
 * Author: Sahil Bansall
 * Date: 4/24/19
 * Edited By: Troy Mateo
 */
// C# code to create a Queue 
//Added demonstration of dequeue method
//Refactored to make less lines of code
using System;
using System.Collections;

class GFG
{

    // Driver code 
    public static void Main()
    {

        // Creating a Queue  
        Queue myQueue = new Queue();

        // Inserting the elements into the Queue 
        myQueue.Enqueue("one");

        // Displaying the count of elements 
        // contained in the Queue 
        Console.WriteLine("Total number of elements in the Queue are : " + myQueue.Count);

        myQueue.Enqueue("two");

        // Displaying the count of elements 
        // contained in the Queue 
        Console.WriteLine("Total number of elements in the Queue are : " + myQueue.Count);

        myQueue.Enqueue("three");

        // Displaying the count of elements 
        // contained in the Queue 
        Console.WriteLine("Total number of elements in the Queue are : " + myQueue.Count);

        myQueue.Enqueue("four");

        // Displaying the count of elements 
        // contained in the Queue 
        Console.WriteLine("Total number of elements in the Queue are : " + myQueue.Count);


        myQueue.Enqueue("five");

        // Displaying the count of elements 
        // contained in the Queue 
        Console.WriteLine("Total number of elements in the Queue are : " + myQueue.Count);

        myQueue.Enqueue("six");

        // Displaying the count of elements 
        // contained in the Queue 
        Console.WriteLine("Total number of elements in the Queue are : " + myQueue.Count);

        //Demonstrating the dequeue method as well
        myQueue.Dequeue();
        Console.WriteLine("Total number of elements in the Queue are : " + myQueue.Count);
    }
}

//Output
//Total number of elements in the Queue are : 1
//Total number of elements in the Queue are : 2
//Total number of elements in the Queue are : 3
//Total number of elements in the Queue are : 4
//Total number of elements in the Queue are : 5
//Total number of elements in the Queue are : 6
//Total number of elements in the Queue are : 5