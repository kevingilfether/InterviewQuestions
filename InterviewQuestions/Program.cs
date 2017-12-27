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

            Console.WriteLine(GetMaxProfitBrute(prices));



        }

        public static int GetMaxProfitBrute(int[] prices)
        {
            //return this
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = 0; j < prices.Length; j++)
                {
                    if (j > i)
                    {
                        if ((prices[j] - prices[i]) > maxProfit)
                            maxProfit = prices[j] - prices[i];
                    }
                }
            }
            return maxProfit;
        }

        public static int GetMaxProfitOneLoop(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = prices[0];

            for (int i =0; i<prices.Length; i++)
            {
                if 
            }

        }

    
    }
}
