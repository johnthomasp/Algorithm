using System;


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