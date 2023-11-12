namespace Leetcode._205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static bool IsIsomorphic(string s, string t)
            {
                Dictionary<char, char> dict = new Dictionary<char, char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict.ContainsKey(s[i]))
                    {
                        if (dict[s[i]] != t[i])
                        {
                            return false;
                        }
                    } else
                    {
                        if (dict.ContainsValue(t[i]))
                        {
                            return false;
                        }
                        dict.Add(s[i], t[i]);
                    }
                }
                return true;
            }
        }
    }
}