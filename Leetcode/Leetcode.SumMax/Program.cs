namespace Leetcode.SumMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.MaxSubArray(new int[10] { -1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
        }
    }

    public static class Solution
    {
        public static int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];
            int currentSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}