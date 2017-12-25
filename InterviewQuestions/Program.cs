using System;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //12-25
            //InterviewCake - Stock Prices
            //https://www.interviewcake.com/question/javascript/stock-price

            int[] prices = { 15, 20, 21, 35, 5, 34 };

            Console.WriteLine(GetMaxProfitBroken(prices));



        }

        public static int GetMaxProfitBroken(int[] prices)
        {
            //return this
            int maxProfit = 0;
            //This is the minimum before the maximum
            int minLocal = 0;
            int minIndex = 0;
            //Max and index
            int max = 0;
            int maxIndex = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > max)
                {
                    max = prices[i];
                    maxIndex = i;
                }

            }
            for (int i = 0; i<prices.Length; i++ )
            {
                if (i == 0)
                    minLocal = prices[i];
                else if (prices[i] < minLocal && i < maxIndex)
                    minLocal = prices[i];
            }
            maxProfit = max - minLocal;
            return maxProfit;
        }
    }
}
