using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 1, 5, 3, 6, 4 };
            int result = AddArray(arr);
            Console.WriteLine("The total of array is {0}", result);
            Console.ReadLine();
        }

        private static int AddArray(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
    }
}