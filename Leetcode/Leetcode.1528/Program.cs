using System.Text;

namespace Leetcode._1528
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static string RestoreString(string s, int[] indices)
            {
                char[] result = new char[indices.Length];
                for (int i = 0; i < indices.Length; i++)
                {
                    result[indices[i]] = s[i];
                }
                return new string(result);
            }
        }
    }
}