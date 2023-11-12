namespace Leetcode.DayoftheYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.DayOfYear("2003-03-01"));
        }
    }

    public static class Solution
    {
        public static int DayOfYear(string date)
        {
            string strmonth = date[5..7];
            string stryear = date[0..4];
            string strday = date[8..];
            int year = int.Parse(stryear);
            int month = int.Parse(strmonth);
            int day = int.Parse(strday);
            if (month == 1)
            {
                return day;
            }
            else
            {
                int sum = 0;
                for (int i = 1; i < month; i++)
                {
                    sum += DayOfMonth(i, year);
                }
                Console.WriteLine(day);
                sum += day;
                return sum;
            }
        }

        public static int DayOfMonth(int month, int year)
        {
            return month switch
            {
                4 => 30,
                6 => 30,
                9 => 30,
                11 => 30,
                2 => isYear(year) ? 28 : 29,
                _ => 31
            };
        }

        public static bool isYear(int year)
        {
            if (year % 4 == 0 || year % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}