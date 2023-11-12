namespace Leetcode._1281
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static int SubtractProductAndSum(int n)
            {
                string str_n = n.ToString();
                int mul = 1, sum = 0;
                foreach (var item in str_n)
                {
                    mul *= item - '0';
                    sum += item - '0';
                }
                return mul - sum;
            }
        }
    }
}