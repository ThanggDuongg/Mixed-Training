bool WordPattern(string pattern, string s)
{
    var stringArr = s.Split(' ');
    if (stringArr.Length != pattern.Length)
    {
        return false;
    }

    var dict = new Dictionary<char, string>();
    for (int i = 0; i < pattern.Length; i++)
    {
        if (!dict.ContainsKey(pattern[i]))
        {
            if (dict.ContainsValue(stringArr[i]))
            {
                return false;
            } else
            {
                dict.Add(pattern[i], stringArr[i]);
            }
        } 
        else if (dict[pattern[i]] != stringArr[i])
        {
            return false;
        }
    }
    return true;
}

WordPattern("abba", "dog dog dog dog");