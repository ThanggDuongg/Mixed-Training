namespace Leetcode.CountWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var s in Solution.CountWords("ab ab bc ab cd")) {
                Console.WriteLine($"key: {s.Key} value: {s.Value}"); 
            }
        }

        public static class Solution
        {
            public static IDictionary<string, int> CountWords(string s)
            {
                IDictionary<string, int> counts = new Dictionary<string, int>();
                string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (counts.ContainsKey(word))
                    {
                        counts[word]++;
                    }
                    else
                    {
                        counts.Add(word, 1);
                    }
                }

                return counts;
            }
        }
    }
}