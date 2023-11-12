namespace Leetcode.ShuffletheArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static int[] Shuffle(int[] nums, int n)
            {
                int[] result = new int[nums.Length];
                result[0] = nums[0];
                int start1 = 1, start2 = n;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        result[i] = nums[start1++];
                    } else
                    {
                        result[i] = nums[start2++];
                    }
                }
                return result;
            }
        }
    }
}