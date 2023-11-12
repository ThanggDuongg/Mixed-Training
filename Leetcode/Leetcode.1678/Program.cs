using System.Text;

namespace Leetcode._1678
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static string Interpret(string command)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < command.Length; i++)
                {
                    if (i < command.Length - 1 && command[i] == '(' && command[i + 1] == ')')
                    {
                        sb.Append('o');
                    }
                    else if ((command[i] >= 'A' && command[i] <= 'Z') || (command[i] >= 'a' && command[i] <= 'z'))
                    {
                        sb.Append(command[i]);
                    }
                }
                return sb.ToString();
            }
        }
    }
}