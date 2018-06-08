using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfArrayElementsAreConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 1, 5, 3, 6, 4 };
            int result = CheckElementsAreConsecutive(arr);
            Console.WriteLine("The total of array is {0}", result);
            Console.ReadLine();
        }
    }
}
