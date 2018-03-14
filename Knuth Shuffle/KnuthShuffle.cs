using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnuthShuffle
{
    class KnuthShuffle
    {
        public static Random rnd = new Random();
        public static int[] ShuffleArray(int[] inputArray)
        {
            int temp = 999999;
            for (int i = inputArray.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                temp = inputArray[i];
                inputArray[i] = inputArray[j];
                inputArray[j] = temp;
            }
            return inputArray;
        }


        public static void PrintArray(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i < inputArray.Length - 1)
                    Console.Write(inputArray[i] + ",");
                else
                    Console.Write(inputArray[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("The input array is : ");
            KnuthShuffle.PrintArray(inputArray);
            KnuthShuffle.ShuffleArray(inputArray);
            Console.Write("\nThe Shuffled array is : ");
            KnuthShuffle.PrintArray(inputArray);

            Console.ReadLine();
        }
    }
}