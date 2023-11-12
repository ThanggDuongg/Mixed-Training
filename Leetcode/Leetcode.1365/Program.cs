namespace Leetcode._1365
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static int[] SmallerNumbersThanCurrent(int[] nums)
            {
                int[] res = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (i != j & nums[i] < nums[j])
                        {
                            count++;
                        }
                    }
                    res[i] = count;
                }
                return res;
            }
        }
    }
}