using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {

        static int GCD(int a, int b)
        {
            if (a == b)
                return a;
            else if (a % b == 0)
                return b;
            else if (b % a == 0)
                return a;
            else if (a > b)
                return GCD(a % b, b);
            else
                return GCD(a, b % a);
        }

        static void Main(string[] args)
        {
            int a = 105, b = 91;
            int result = GCD(a, b);
            Console.WriteLine("The GCD for {0} and {1} is {2}", a, b, result);
            Console.ReadLine();
        }
    }
}