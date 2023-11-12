using System.Numerics;
using System.Text;

namespace Leetcode.PartitioningIntoMinimumNumberOfDeciBinaryNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.MinPartitions("21119191991919199119919119911919991119191919199"));
        }

        public static class Solution
        {
            public static int MinPartitions(string n)
            {
                int max = n[0] - '0';
                for (int i = 1; i < n.Length; i++) { 
                    if (max < n[i] - '0')
                    {
                        max = n[i] - '0';
                    }
                }
                return max;
                /*int count = 0;
                while (BigInteger.Parse(n) > 0)
                {
                    n = genOne(n);
                    count++;
                }
                return count;*/
            }

            /*public static string genOne(string n)
            {
                StringBuilder res = new StringBuilder();
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] - '0' == 0)
                    {
                        res.Append("0");
                    }
                    else {
                        res.Append("1");
                    }
                }
                return (BigInteger.Parse(n) - BigInteger.Parse(res.ToString())).ToString();
            }*/
        }
    }
}