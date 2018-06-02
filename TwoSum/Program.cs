using System;
using System.Collections.Generic;

///<summary>
/// https://leetcode.com/problems/two-sum/description/
/// Given an array of integers, return indices of the two numbers 
/// such that they add up to a specific target.
/// You may assume that each input would have exactly one solution, 
/// and you may not use the same element twice.
/// Example:
/// Given nums = [2, 7, 11, 15], target = 9,
/// Because nums[0] + nums[1] = 2 + 7 = 9,
/// return [0, 1].
///
/// Method 1:
///  Run two loops to find the indices, 
///  Time Complexity o(n2)
/// Method 2:
///  Run two pointers to find the indices.Time Complexity o(n) but needs a sorted array
///  Time Complexity o(n)
///  2,5,11,15
///  ^       ^
/// Method 3:
///  Use DS like dictionary to keep a track of visited array element.
///  Time Complexity o(n)
///</summary>


namespace Algo
{
    class Program
    {
        static int[] TwoSums(int[] arr, int target)
        {
            Dictionary<int, int> visited = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (visited.ContainsKey(target - arr[i]))
                {
                    return new int[] { visited[target - arr[i]], i };
                }

                visited.Add(arr[i], i);
            }

            return new int[] { -1, -1 };
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSums(arr, target);
            Console.WriteLine("The incides for the target is on {0} and {1}", result[0], result[1]);
            Console.ReadLine();
        }
    }
}