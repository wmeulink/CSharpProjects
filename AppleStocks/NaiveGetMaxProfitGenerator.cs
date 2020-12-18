using System;

namespace AppleStocks
{
    /// <summary>
    /// This is Big O(squared(n))
    /// </summary>
    class NaiveGetMaxProfitGenerator : IMaxProfitGenerator
    {

        public int GetMaxProfit(int[] stockPrices)
        {
            if (stockPrices == null || stockPrices.Length < 2)
            {
                throw new Exception("Array cannot be null and must be at least two elements.");
            }

            int lowest = stockPrices[0];
            int maxProfit = stockPrices[1] - stockPrices[0];
            for (int i = 1; i < stockPrices.Length - 1; i++)
            {
                if (stockPrices[i] < lowest)
                {
                    lowest = stockPrices[i];
                }
                for (int j = i + 2; j < stockPrices.Length; j++)
                {
                    int profit = stockPrices[j] - lowest;
                    if (maxProfit < profit)
                    {
                        maxProfit = profit;
                    }
                }


            }

            return maxProfit;
        }

    }
}
