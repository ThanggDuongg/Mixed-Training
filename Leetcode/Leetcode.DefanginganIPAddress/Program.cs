namespace Leetcode.DefanginganIPAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.DefangIPaddr("255.100.50.0"));
        }

        public static class Solution
        {
            public static string DefangIPaddr(string address)
            {
                return string.Join("[.]", address.Split('.'));
            }
        }

    }
}