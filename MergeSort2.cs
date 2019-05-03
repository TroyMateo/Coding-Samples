/*https://www.geeksforgeeks.org/merge-sort/
 * Author: Rajat Mishra
 * Date: 03 May 2019
 * Edited By: Troy Mateo
 * C# Program demonstrating merge sort
 * 1)Translated from java to c#
 */

using System;
using System.Collections.Generic;
using System.Text;


namespace MergeSort2
{

    class MergeSort
    {
        // Merges two subarrays of arr[]. 
        // First subarray is arr[l..m] 
        // Second subarray is arr[m+1..r] 
        void merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two subarrays to be merged 
            int n1 = m - l + 1;
            int n2 = r - m;

            //Create two temporary sub arrays
            int [] L = new int[n1];
            int [] R = new int[n2];

            /*Copy data to temp arrays*/
            for (int ii = 0; ii < n1; ++ii)
                L[ii] = arr[l + ii];
            for (int jj = 0; jj < n2; ++jj)
                R[jj] = arr[m + 1 + jj];


            //Merge the temporary arrays together

            // Initial indexes of first and second subarrays 
            int i = 0, j = 0;

            // Initial index of merged subarry array 
            int k = l;
            while (i < n1 && j < n2)
            {
                //If the element at position i in L array is less than R's
                //Stick that element value into new merged array K and increment i to compare the next element
                //Otherwise do the vice versa with array R at position j
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements of L[] if any 
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements of R[] if any 
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        //The function that splits, sorts, then calls the merge method on the array
        void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point 
                int m = (l + r) / 2;

                // Sort first and second halves 
                sort(arr, l, m);
                sort(arr, m + 1, r);

                // Merge the sorted halves 
                merge(arr, l, m, r);
            }
        }

        //Method that prints out the array called on
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
           Console.WriteLine();
        }

        // Driver method 
        static void Main(String[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };

           Console.WriteLine("Given Array");
            printArray(arr);

            MergeSort ob = new MergeSort();
            ob.sort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nSorted array");
            printArray(arr);
        }
    }
}

//Output
//Given Array
//12 11 13 5 6 7

//Sorted array
//5 6 7 11 12 13
