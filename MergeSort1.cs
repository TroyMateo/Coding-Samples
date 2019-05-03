/*https://www.sanfoundry.com/csharp-program-merge-sort/
 * Author: Manish Bhojasia
 * Date: 4/30/19
 *  C# Program to Perform Merge Sort
 *  Edited: Troy Mateo
 *  1) Added function to display the unsorted array first
 *  2) Refactored to make more readable and output cleaner
 */
using System;
using System.Collections.Generic;
using System.Text;
namespace prog
{
    class Program
    {
        static public void mergemethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            //Creates size of the left array
            left_end = (mid - 1);
            tmp_pos = left;
            //Creates size of the right array
            num_elements = (right - left + 1);
            //Compares the values of elements of the two subarrays and inputs them into a new combined array
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            //Whatever is leftover after the comparison is then input into the array
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }

        }
        // This is the method that will sort the arrays by splittng the arrays with recursion
        //After splitting the array it will then call the mergemethod to combine the arrays
        static public void sortmethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                sortmethod(numbers, left, mid);
                sortmethod(numbers, (mid + 1), right);
                mergemethod(numbers, left, (mid + 1), right);

            }
        }
        static void Main(string[] args)

        {

            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            //Prints out the given the array
            Console.WriteLine("Unsorted Array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            //Prints out the sorted array
            Console.WriteLine("MergeSort :");
            sortmethod(numbers, 0, numbers.Length - 1);
            for (int i = 0; i < 9; i++)
                Console.Write(numbers[i] + " ");
            Console.Read();
        }
    }
}

//Output
//Unsorted Array:
//3 8 7 5 2 1 9 6 4
//MergeSort :
//1 2 3 4 5 6 7 8 9