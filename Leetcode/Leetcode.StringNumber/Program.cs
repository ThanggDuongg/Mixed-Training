Solution solution = new Solution();
Console.WriteLine(solution.solution("23"));

class Solution
{
    public int solution(String S)
    {
        long numOfString = long.Parse(S);
        long max = maxOfNum(S.Length);
        int count = 0;
        //if (numOfString >= 3)
        //{
        //    count++;
        //}

        long i = 1;
        while (i < max)
        {
            long a = i % 3;
            if (i % 3 == 0)
            {
                count++;
            }
            i++;
        }

        return count;
    } 

    public long maxOfNum(int len)
    {
        long res = 9;
        for (int i = 1; i < len; i++)
        {
            res = res * 10 + 9;
        }
        return res;
    }
}