Solution solution = new Solution();
//int[] res = solution.PlusOne(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 9, 9 });
int[] res = solution.PlusOne(new int[] { 9, 9 });
foreach (var item in res)
{
    Console.WriteLine(item);
}

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int last_digit = digits[digits.Length - 1];
        if (last_digit < 9)
        {
            digits[digits.Length - 1] = last_digit + 1;
            
        } else
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                    if (i == 0)
                    {
                        string temp = "1" + string.Join("", digits);
                        return temp.Select(n => int.Parse(n.ToString())).ToArray();
                    } 
                } else
                {
                    digits[i] += 1;
                    break;
                }
            }
        }
        return digits;
    }
}