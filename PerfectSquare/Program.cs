using System;
namespace PerfectSquare
{
   /*
   Given an integer x, find square root of it.If x is not a perfect square, then return floor(√x).

   Examples :
       Input: x = 4
       Output: 2

       Input: x = 11
       Output: 3
   Url: https://www.geeksforgeeks.org/square-root-of-an-integer/
   */
    class Program
    {

        static int PerfectSquare(int num)
        {
            if (num == 0 || num == 1)
                return num;

            int start = 1;
            int end = num;
            int ans = 0;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (mid * mid == num)
                 return mid;

                if (mid * mid < num)
                {
                    start = mid + 1;
                    ans = mid;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return ans;
        }

        static void Main(string[] args)
        {

            int num = 11;
            int result = PerfectSquare(num);
            Console.WriteLine("The perfect Square for the number is {0}", result);
            Console.ReadLine();
        }
    }
}