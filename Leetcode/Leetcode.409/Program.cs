namespace Leetcode._409
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static int LongestPalindrome(string s)
            {
                HashSet<char> list = new HashSet<char>();
                int count = 0;
                foreach (char c in s) { 
                    if (list.Contains(c))
                    {
                        list.Remove(c);
                        count++;
                    } else
                    {
                        list.Add(c);
                    }
                }

                return count * 2 + (list.Count == 0 ? 0 : 1);
        }
    }
}