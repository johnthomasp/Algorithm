using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        private static int Calculatefactorial(int n)
        {
            if (n==0)
                return 1;
            else
                return n * Calculatefactorial(n-1);
        }

        static void Main(string[] args)
        {
            int n = 0;
            int result = Calculatefactorial(n);
            Console.WriteLine("The factorial of {0} is {1}", n, result );
            Console.ReadLine();
        }
    }
}
