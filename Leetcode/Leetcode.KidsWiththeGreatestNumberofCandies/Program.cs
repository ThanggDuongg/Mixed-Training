namespace Leetcode.KidsWiththeGreatestNumberofCandies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
            {
                int max = candies.Max();
                bool[] res = new bool[candies.Length];
                for (int i = 0; i < candies.Length; i++)
                {
                    if (candies[i] + extraCandies >= max)
                    {
                        res[i] = true;
                    } else
                    {
                        res[i] = false;
                    }
                }
                return res;
            }
        }
    }
}