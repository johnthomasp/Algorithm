using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Time Complexity - Worst Case O(n2) Best Case O(n) Avergae Case O(n2)
//Space Complexity - O(1)

namespace InsertionSort
{
    static class InsertionSort
    {
        public static void Sort(int[] list)
        {
            int i, j, key;

            for (i = 1; i < list.Length; i++)
            {
                key = list[i];
                j = i - 1;

                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }

                list[j + 1] = key;
            }

        }

        static void Main(string[] args)
        {
            int[] list = new int[] { 8, 9, 5, 2, 3 };
            Sort(list);
            printlist(list);
            Console.ReadLine();
        }

        private static void printlist(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
