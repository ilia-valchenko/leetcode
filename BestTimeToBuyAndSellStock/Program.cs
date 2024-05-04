using System;

namespace BestTimeToBuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            var testItems = new[]
            {
                new TestItem
                {
                    InputArray = new [] { 7, 1, 5, 3, 6, 4 },
                    Result = 7
                },
                new TestItem
                {
                    InputArray = new [] { 1, 2, 3, 4, 5 },
                    Result = 4
                },
                new TestItem
                {
                    InputArray = new [] { 7, 6, 4, 3, 1 },
                    Result = 0
                }
            };

            foreach (var testItem in testItems)
            {
                var actualResult = MaxProfit(testItem.InputArray);

                if (actualResult != testItem.Result)
                {
                    Console.WriteLine($"\n\nFAILED. Expected: {testItem.Result}. Actual: {actualResult}. Input array: [{ToString(testItem.InputArray)}].");
                }
            }

            Console.WriteLine("Tap to continue...");
            Console.ReadKey();
        }

        private static int MaxProfit(int[] prices)
        {
            if (prices.Length == 1)
            {
                return 0;
            }

            var profit = 0;
            var buyPrice = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (buyPrice >= prices[i])
                {
                    // Change buy price.
                    buyPrice = prices[i];
                }

                if (i + 1 != prices.Length && buyPrice < prices[i+1])
                {
                    profit = prices[i + 1] - buyPrice;
                }
            }

            return profit;
        }

        private static string ToString<T>(T[] array)
        {
            return string.Join(",", array);
        }
    }
}
