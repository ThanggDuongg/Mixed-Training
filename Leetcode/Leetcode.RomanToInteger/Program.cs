Solution solution = new Solution();
solution.RomanToInt("MCMXCIV");

public class Solution
{
    public int RomanToInt(string s)
    {
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int checkResult = -1;
            if (i < s.Length - 1)
            {
                checkResult = check(s[i], s[i + 1]);
            }

            if (checkResult != -1)
            {
                sum += checkResult;
                i = i + 1;
            }
            else
            {
                sum += revert(s[i]);
            }
        }
        return sum;
    }

    public int check(char i, char j)
    {
        if (i == 'I')
        {
            return j switch
            {
                'V' => 4,
                'X' => 9,
                _ => -1,
            };
        }
        else if (i == 'X')
        {
            return j switch
            {
                'L' => 40,
                'C' => 90,
                _ => -1,
            };
        }
        else if (i == 'C')
        {
            return j switch
            {
                'D' => 400,
                'M' => 900,
                _ => -1,
            };
        }
        return -1;
    }

    public int revert(char c)
    {
        return c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0,
        };
    }
}