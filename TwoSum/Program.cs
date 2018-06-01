using System;
using System.Collections.Generic;

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