/*https://www.geeksforgeeks.org/find-subarray-with-given-sum/
 *C# code to Find subarray 
 *with given sum
 * Author: nitin mittal
 * Date: 03 May 2019
 * Edited By: Troy Mateo
 */

using System;

class GFG
{
    //If a subarray has a curr_sum that is equal to sum then it returns true
    //If it does'nt find that subarray with equivalent sum it returns false
    int subArraySum(int[] arr, int n,
                               int sum)
    {
        int curr_sum, i, j;

        //Starting point starts at i 
        for (i = 0; i < n; i++)
        {
            //curr_sum set to initial element of the array
            curr_sum = arr[i];

            // try all subarrays starting with i, if not found then i is incremented
            // subarray is shifted over and iterated again
            for (j = i + 1; j <= n; j++)
            {
                //if the current sum is found break out of the loop you;ve found between what indeces is your sum
                if (curr_sum == sum)
                {
                    int p = j - 1;
                    Console.WriteLine("Sum found between indexes " + i + " and " + p);
                    return 1;
                }
                //When adding up the current sum if it exceeds the sum you are looking for it breaks out of the loop
                if (curr_sum > sum || j == n)
                    break;
                //while iterating through the array curr-sum continues to add next elements as long as it does not exceed sum you're looking for
                curr_sum = curr_sum + arr[j];
            }
        }

        Console.Write("No subarray found");
        return 0;
    }

    // Driver Code 
    public static void Main()
    {
        GFG arraysum = new GFG();
        int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
        int n = arr.Length;
        int sum = 23;
        arraysum.subArraySum(arr, n, sum);
    }
}

//Output
//Sum found between indexes 1 and 4