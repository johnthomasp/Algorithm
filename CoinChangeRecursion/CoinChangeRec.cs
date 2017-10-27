using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangeRecursion
{
    public static class CoinChange
    {
        public static int FindCoinChange(int amount, int[] Coins ,int currentCoin)
        {
            if (amount == 0)
                return 1;

            if (amount < 0)
                return 0;

            int nCombos = 0;

            for (int coin = currentCoin; coin < Coins.Length; coin++)
            {
                nCombos += FindCoinChange(amount - Coins[coin], Coins, coin);
            }
            return  nCombos;
        }
    }

    class CoinChangeRec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total amount");
            int amount = int.Parse(Console.ReadLine());

            int result = CoinChange.FindCoinChange(amount, new int[] { 1, 2 }, 0);
            Console.WriteLine("The minimum number of coins needed is {0} to form a total of {1}", result, amount);
            Console.ReadLine();
        }
    }
}