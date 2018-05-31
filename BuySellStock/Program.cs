using System;

///<summary>
///Given an array for which the ith element is the price of a given stock on day i.
///If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), 
///design an algorithm to find the maximum profit.
///Note that you cannot sell a stock before you buy one.
///</summary>

namespace BuySellStock
{
    class Program
    {
        
        private static int CalculateMaxProfit(int[] stockPrices)
        {
            int mxp = 0;
            int mip = int.MaxValue;
            for (int i = 0; i < stockPrices.Length; i++)
            {
                if (stockPrices[i] - mip > mxp)
                {
                    mxp = stockPrices[i] - mip;
                }
                if (stockPrices[i] < mip)
                {
                    mip = stockPrices[i];
                }
            }
            return mxp;
        }

        static void Main(string[] args)
        {
            int[] stockPrices = { 7, 1, 5, 3, 6, 4 };
            //int[] stockPrices = { 7, 6, 4, 3, 1 };
            int maxProfit = CalculateMaxProfit(stockPrices);
            Console.WriteLine("The maximum profit for the stock is {0}", maxProfit);
            Console.ReadLine();
        }
    }
}
