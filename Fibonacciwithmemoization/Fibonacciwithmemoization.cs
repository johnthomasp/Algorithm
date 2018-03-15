using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacciwithmemoization
{
    class Fibonacciwithmemoization
    {
        private static int CalculateFibonacci(int n)
        {
            int[] cache = new int[n];

            if (n <=1)
                return n;

            for (int i = 0; i<= n-1; i++)
            {
                cache[i] = -1;
            }

            if (cache[n-1] != -1)
                return cache[n-1];

            int res = CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
            cache[n-1] = res;
            return cache[n-1];
        }

        static void Main(string[] args)
        {
            int n = 30;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = Fibonacciwithmemoization.CalculateFibonacci(n);
            Console.WriteLine("The Fibonacci number of {0} is {1}", n, result);

            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

            Console.ReadLine();
        }
    }
}
