using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{

    class Program
    {
        public static void FizzBuzz(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                if(i % 3 == 0 && i % 5 == 0 )
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int x = int.Parse(Console.ReadLine());
            FizzBuzz(x);
            Console.ReadLine();
        }
    }
}
