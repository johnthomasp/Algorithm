using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempQuickSort
{
    class Program
    {
        public static void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int q = Partition(arr, start, end);
                Sort(arr, start, q - 1);
                Sort(arr, q + 1, end);
            }
        }

        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, end);
            return i + 1;
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void PrintList(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 89, 54, 99, 21, 45, 11, 32 };
            Console.WriteLine("UnsortedList");
            PrintList(arr);
            Sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSortedList");
            PrintList(arr);
            Console.ReadLine();
        }
    }
}
