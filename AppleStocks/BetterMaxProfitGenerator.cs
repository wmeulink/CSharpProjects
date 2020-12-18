using System;

namespace AppleStocks
{
    /// <summary>
    /// This is Big O(n)
    /// </summary>
    class BetterGetMaxProfitGenerator : IMaxProfitGenerator
    {
        public int GetMaxProfit(int[] stockPrices)
        {
            if (stockPrices == null || stockPrices.Length < 2)
            {
                throw new Exception("Array cannot be null and must be at least two elements.");
            }

            //initialize maxProfit to first interval
            int maxProfit = stockPrices[1] - stockPrices[0];
            //initialize lowest to the lowest value out of the first two stock prices
            int lowest = stockPrices[0] < stockPrices[1] ? stockPrices[0] : stockPrices[1];

            for (int i = 2; i < stockPrices.Length; i++)
            {
                //update max profit if needed
                if (maxProfit < stockPrices[i] - lowest)
                {
                    maxProfit = stockPrices[i] - lowest;
                }

                //Update lowest if needed
                if (stockPrices[i] < lowest)
                {
                    lowest = stockPrices[i];
                }

            }

            return maxProfit;
        }
    }
}
