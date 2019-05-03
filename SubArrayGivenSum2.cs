/*https://www.geeksforgeeks.org/find-subarray-with-given-sum/
* An efficient C# program to print  
* subarray with sum as given sum 
*Author: KRV
* Date: 03 May 2019
* Edited By: Troy Mateo
*/
using System;

class GFG
{

    //Returns true when a subarray with curr_sum equal to sum is found
    //Else returns false and prints that no subarray has been found
    int subArraySum(int[] arr, int n,
                               int sum)
    {
        int curr_sum = arr[0],
                 start = 0, i;

        // Pick a starting point 
        for (i = 1; i <= n; i++)
        {
            //If the sum is exceeded by the curr_sum trailing elements are removed
            while (curr_sum > sum &&
                   start < i - 1)
            {
                curr_sum = curr_sum -
                           arr[start];
                start++;
            }

           //Returns true when curr_sum becomes equal to sum
            if (curr_sum == sum)
            {
                int p = i - 1;
                Console.WriteLine("Sum found between " +
                                     "indexes " + start +
                                           " and " + p);
                return 1;
            }

            // Add this element to curr_sum 
            if (i < n)
                curr_sum = curr_sum + arr[i];

        }
        Console.WriteLine("No subarray found");
        return 0;
    }

    // Driver code 
    public static void Main()
    {
        GFG arraysum = new GFG();
        int[] arr = new int[] {15, 2, 4, 8,
                              9, 5, 10, 23};
        int n = arr.Length;
        int sum = 23;
        arraysum.subArraySum(arr, n, sum);
    }
}

//Output
//Sum found between indexes 1 and 4