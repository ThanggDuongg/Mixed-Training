namespace Leetcode._2160
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static int MinimumSum(int num)
            {
                string str_num = num.ToString();
                int[] num_array = num.ToString().Select(o => int.Parse(o.ToString())).ToArray();
                Array.Sort(num_array);
                return num_array[0] + num_array[1];
            }
        }
    }
}