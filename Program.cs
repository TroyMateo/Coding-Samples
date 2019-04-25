/*
 * https://www.sanfoundry.com/csharp-program-stack-push-pop/
 * Author: Manish Bhojasia
 * Date: 4/24/19
 * C# Program to Implement Stack with Push and Pop operations
 * Edited by: Troy Mateo
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //A new stack variable is created
            stack st = new stack();
            //The programmer displays the menu of what you can do with the stack
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nStack MENU(size -- 10)");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //Switch statements used to reflect the options of the above menu
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an Element : ");
                        st.Push(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Top element is: {0}", st.Peek());
                        break;

                    case 3:
                        Console.WriteLine("Element removed: {0}", st.Pop());
                        break;

                    case 4:
                        st.Display();
                        break;

                    case 5:
                        System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
    //This is programmer's stack interface
    interface StackADT
    {
        Boolean isEmpty();
        void Push(Object element);
        Object Pop();
        Object Peek();
        void Display();
    }
    //Stack class that implements the interface methods
    class stack : StackADT
    {
        private int StackSize;
        public int StackSizeSet
        {
            get { return StackSize; }
            set { StackSize = value; }
        }
        public int top;
        Object[] item;
        //Figuring out the size of the stack
        public stack()
        {
            StackSizeSet = 10;
            item = new Object[StackSizeSet];
            top = -1;
        }
        //Checking if the stack is full
        public stack(int capacity)
        {
            StackSizeSet = capacity;
            item = new Object[StackSizeSet];
            top = -1;
        }
        //Checking for any elements in the stack
        public bool isEmpty()
        {
            if (top == -1) return true;

            return false;
        }
        //This takes the input element and pushes it right on top of the stack
        public void Push(object element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }

            else
            {

                item[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }
        //Popping is removing the top element from the stack
        public object Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {

                return item[top--];
            }
        }
        //Peeking allows you to see what element you have on the top
        public object Peek()
        {
            if (isEmpty())
            {

                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return item[top];
            }
        }

        //Displaying goes through all of the elements in the stack from top to bottom display
        public void Display()
        {
            for (int i = top; i > -1; i--)
            {

                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
            }
        }
    }
}
//Output is whatever you menu options you follow
//Example i push 3 then 4 then 5
//Displays successful after each push
//Displays the elements 5 4 3 from top to bottom