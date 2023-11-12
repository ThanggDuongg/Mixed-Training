namespace Leetcode.ConcatenationofArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Solution.GetConcatenation(new int[] { 1, 3, 2, 1 }))
            {
                Console.WriteLine(item);
            }
        }

        public static class Solution
        {
            public static int[] GetConcatenation(int[] nums)
            {
                return nums.Concat(nums).Cast<int>().ToArray();
            }
        }
    }
}