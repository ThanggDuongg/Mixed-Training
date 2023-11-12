namespace Leetcode._392
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ahbgdc".IndexOf('a'));
            Console.WriteLine(Solution.IsSubsequence("axc", "ahbgdc"));
        }

        public static class Solution
        {
            public static bool IsSubsequence(string s, string t)
            {
                int j = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    int flag = 0;
                    while (j < t.Length)
                    {
                        if (s[i] == t[j])
                        {
                            flag = 1;
                            j++;
                            break;
                        }
                        j++;
                    }

                    if (flag == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}