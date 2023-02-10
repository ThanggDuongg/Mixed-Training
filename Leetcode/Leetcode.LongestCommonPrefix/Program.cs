Solution solution = new Solution();
string[] input = new string[] { "abca", "aba", "aaab" };
Console.WriteLine(solution.LongestCommonPrefix(input));

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (prefix.Length > 0 && strs[i].IndexOf(prefix) != 0)
            {
                if (strs[i].Contains(prefix) && strs[i].IndexOf(prefix) == 0)
                {
                    break;
                }
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
            if (prefix.Length <= 0 || strs[i].IndexOf(prefix) != 0)
            {
                return "";
            } 
        }
        return prefix;
    }
}