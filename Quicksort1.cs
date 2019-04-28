/*https://www.sanfoundry.com/csharp-program-quick-sort/
 * Author:Manish Bhojasia
 * Date: 04/27/19
 * Edited By: Troy Mateo
 *  C# Program to Implement Quick Sort
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortQuick
{
    //Quicksort class defining the sorting methods for quicksorting a collection
    class quickSort
    {
        //An array of integers array is created and initialized to 20 elements
        //This array will be the one to be sorted
        private int[] array = new int[20];
        private int len;

        //QuickSort method that calls on the sort method
        public void QuickSort()
        {
            sort(0, len - 1);
        }

        //Sort method takes in two parameters that are integers labeled left and right
        //The left and right parameters define the elements that will end up being compared
        public void sort(int left, int right)
        {
            //Pivot is the variable that all other elements are compared against
            //After the initial pass all the variables are split into partition and new pivot is assigned and compared against
            int pivot, leftend, rightend;

            leftend = left;
            rightend = right;
            pivot = array[left];

            //This is while the comparing indeces have not crossed each other yet
            while (left < right)
            {
                //If the value of the right index is greater than the pivot value it should be where it belongs
                //The right index is then decremented and the new right value is compared against the pivot
                while ((array[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }

                //Same as above comment except for the left side
                while ((array[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }
            //Array will have been partitioned and the previous variables are set to reflect values of new partition
            array[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;

            if (left < pivot)
            {
                sort(left, pivot - 1);
            }

            if (right > pivot)
            {
                sort(pivot + 1, right);
            }
        }
        //Tester class for the sort method
        public static void Main()
        {
            quickSort q_Sort = new quickSort();

            int[] array = { 4, 3, 1, 4, 6, 7, 5, 4, 32, 5, 26, 187, 8 };
            q_Sort.array = array;
            q_Sort.len = q_Sort.array.Length;
            q_Sort.QuickSort();

            for (int j = 0; j < q_Sort.len; j++)
            {
                Console.Write(q_Sort.array[j] + " ");
            }
            Console.ReadKey();
        }
    }
}

//Output 1 3 4 4 4 5 5 6 7 8 26 32 187
