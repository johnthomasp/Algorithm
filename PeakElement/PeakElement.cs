using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakElement
{

/*
Time complexity : O(log​2(n)). 
We reduce the search space in half at every step. Thus, the total search space will be consumed in log​2(n) steps. 
Here, n refers to the size of array.
*/

/*
Space complexity : O(log​2(n)). 
We reduce the search space in half at every step. Thus, the depth of recursion tree will go upto log​2(n).
*/
    class PeakElement
    {
        static int GetPeakElement(int[] inputArray, int elemCount)
        {
            return GetPeakElementUtil(inputArray, 0, elemCount - 1, elemCount);
        }

        static int GetPeakElementUtil(int[] inputArray, int start, int end, int elemCount)
        {

            int mid = (start + end) / 2;
            
            //compare the middle element with its neighbours
            if ((mid == 0 || inputArray[mid - 1] <= inputArray[mid]) &&
                (mid == elemCount - 1 || inputArray[mid + 1] <= inputArray[mid]))
                return mid;
            else if (mid > 0 && inputArray[mid - 1] > inputArray[mid])
            {
                return GetPeakElementUtil(inputArray, start, (mid - 1), elemCount);
            }
            else
                return GetPeakElementUtil(inputArray, (mid + 1), end, elemCount);  
        }


        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4, 5 };
            //int[] inputArray = { 100, 92, 83, 24, 15 };
            //int[] inputArray = { 1, 2, 3, 1 };
            
            
            int elemCount = inputArray.Length;
            if ((inputArray == null) || (inputArray.Length == 0))
            {
                Console.WriteLine("Array is empty");
            }
            else
            {
                int result = PeakElement.GetPeakElement(inputArray, elemCount);
                Console.WriteLine("The Peak Element is at index {0} and the value is {1}", result, inputArray[result]);
            }
            Console.ReadLine();
        }
    }
}
