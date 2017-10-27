using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangeDP
{
    /* Given coins of certain denominations with infinite supply and a total amount
       Write a function to compute the number of combinations that make up that amount. 
    */

    public static class CoinChange
    {
        public static int FindCoinChange(int Amount, int[] coins)
        {

            int[] combinations = new int[Amount + 1];
            combinations[0] = 1;

            foreach (var coin in coins)
            {
                for (int i = 1; i < combinations.Length; i++)
                {
                    if (i >= coin)
                    {
                        combinations[i] += combinations[i-coin];
                        PrintAmount(combinations);
                    }
                }
                Console.WriteLine();

            }
            return combinations[Amount];
        }

        private static void PrintAmount(int[] combinations)
        {
            for (int i = 0; i < combinations.Length; i++)
            {
                Console.Write(combinations[i] + " ");
            }
            Console.WriteLine();
        }
    }
    class CoinChangeDP
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the total amount");
            int amount = int.Parse(Console.ReadLine());
            
            int result = CoinChange.FindCoinChange(amount, new int[] { 1, 2, 5 });
            Console.WriteLine("The minimum number of coins needed is {0} to form a total of {1}", result, amount);
            Console.ReadLine();
        }
    }
}
