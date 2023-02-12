Solution solution = new Solution();
Console.WriteLine(solution.MySqrt(2147395600));

public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0)
        {
            return 0;
        }
        else if (x == 1)
        {
            return 1;
        }
        else
        {
            long i = 1;
            long flag = i * i;
            while ((long)x >= flag)
            {
                i++;
                flag = i * i;
            }
            return (int)(i - 1);
        }
    }
}