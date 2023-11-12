namespace Leetcode.RichestCustomerWealth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static int MaximumWealth(int[][] accounts)
            {
                int result = 0;
                for (int i = 0; i < accounts.GetLength(0);i++ )
                {
                    result = Math.Max(accounts[i].Sum(), result);
                }
                return result;
            }
        }
    }
}