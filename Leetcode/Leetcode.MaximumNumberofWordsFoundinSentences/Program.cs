namespace Leetcode.MaximumNumberofWordsFoundinSentences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static int MostWordsFound(string[] sentences)
            {
                int max = 0;
                foreach (string sentence in sentences)
                {
                    max = Math.Max(max, sentence.Split(' ').Count());
                }
                return max;
            }
        }
    }
}