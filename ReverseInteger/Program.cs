using System;

/// <summary>
///https://leetcode.com/problems/reverse-integer/description/
/// Given a 32-bit signed integer, reverse digits of an integer.
///Example 1:
///    Input: 123
///    Output: 321
///
///Example 2:
///    Input: -123
///    Output: -321
///Example 3:
///    Input: 120
///    Output: 21
/// </summary>
namespace ReverseInteger
{
    class program
    {
        static int ReverseNumber(int num)
        {
            int rev_num = 0;
            while (num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num = num / 10;
            }

            return rev_num;
        }

        static void Main(string[] args)
        {
            int num = 1234;
            int result = ReverseNumber(num);

            Console.WriteLine("The reverse of {0} is {1}", num, result);
            Console.ReadLine();


        }
    }
}