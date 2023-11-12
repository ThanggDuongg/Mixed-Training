namespace Leetcode.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Solution.ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
        }

        public static class Solution
        {
            public static void ReverseString(char[] s)
            {
                s = s.AsEnumerable().Reverse().ToArray();
                foreach (var item in s.AsEnumerable().Reverse()) {
                    Console.WriteLine(item.ToString()); 
                }
            }
        }
    }
}