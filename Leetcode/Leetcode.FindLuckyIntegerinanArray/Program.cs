namespace Leetcode.FindLuckyIntegerinanArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.FindLucky(new int[] { 5, 4, 7, 8, 4, 8, 8, 3, 7, 7, 6, 3, 7, 6, 5, 6, 8, 4, 5, 7, 4, 7, 7, 5, 2, 5, 6, 6, 8, 1, 6, 8, 8, 8, 9, 3, 2, 9 }));
        }
    }

    public static class Solution
    {
        public static int FindLucky(int[] arr)
        {
            Array.Sort(arr, (x, y) =>  y - x);
            IDictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }
            foreach (var item in dict)
            {
                if (item.Key == item.Value)
                {
                    return item.Key;
                }
            }
            return -1;
        }
    }
}