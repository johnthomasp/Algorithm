using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesInBinaryNumber
{

    /*
       Find the number of ones in a Binary representation of a number

       1(001) = 1
       2(010) = 1
       3(011) = 2
       4(100) = 1
       5(101) = 2

    */
    class Program
    {
        public int Ones(int x)
        {
            int sum = 0;

            while (x > 0)
            {

            }


            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the nth element to be determined:");
            int n = int.Parse(Console.ReadLine());
            int result = Ones(n);
            Console.WriteLine("\nThe no. of ones in {0} is {1}", n, result);
            Console.ReadLine();

        }
    }
}
