using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        private static int  calculateFibonancci(int n)
        {
            if ((n==1) || (n==2))
                return 1;
            else
                return calculateFibonancci(n-1) + calculateFibonancci(n-2);
        }
                
        static void Main(string[] args)
        {
            int n = 5;
            int result = calculateFibonancci(n);
            Console.WriteLine("The fibonacci of {0} is {1}", n, result);
            //Console.WriteLine("The fibonacci of first {0} numbers", n);
            //for (int i = 1; i <= n; i++)
            //{
            //    int result = calculateFibonancci(i);
            //    Console.WriteLine(result);
            //}
            Console.ReadLine();
        }
    }
}
