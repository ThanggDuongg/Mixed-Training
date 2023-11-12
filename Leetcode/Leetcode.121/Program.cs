namespace Leetcode._121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Solution.MaxProfit(new int[] { 2, 4, 1 });
        }

        public static class Solution
        {
            public static int MaxProfit(int[] prices)
            {
                int profit = 0;
                for (int i = 0; i < prices.Length; i++)
                {
                    profit = Math.Max(profit, prices[i..].Max() - prices[i]);
                }
                return profit;
            }
        }
    }
}