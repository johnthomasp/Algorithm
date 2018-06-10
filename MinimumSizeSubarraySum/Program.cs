using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Given an array of n positive integers and a positive integer s, 
/// find the minimal length of a contiguous subarray of which the sum ≥ s. 
/// If there isn't one, return 0 instead
/// Input: s = 7, nums = [2,3,1,2,4,3]
/// Output: 2
/// Explanation: the subarray[4, 3] has the minimal length under the problem constraint.
/// </summary>
namespace MinimumSizeSubarraySum
{
    class Program
    {
        public static int CalculateMinimumSizeSubArray(int[] arr, int value)
        {
            int sum = 0;
            int start = 0;
            int min = arr.Length + 1;
            for (int end = 0; end < arr.Length; end++)
            {
                sum += arr[end];
                while (sum >= value)
                {
                    min = Math.Min(min, end - start + 1);
                    sum -= arr[start];
                    start++;
                }
            }

            return (min == arr.Length + 1) ? 0: min;
        }

        static void Main(string[] args)
        {
            //           int[] arr = {2,3,1,2,4,3};
            //           int[] arr = {  3, 1, 2, };
            int[] arr = { 3, 1, 2, };

            int value = 7;
            int result = CalculateMinimumSizeSubArray(arr, value);
            Console.WriteLine("The minimum values needed to get a sum of {0} is {1}", value, result);
            Console.ReadLine();
        }
    }
}
