bool CanConstruct(string ransomNote, string magazine)
{
    var dict = new Dictionary<char, int>();
    foreach (var item in magazine)
    {
        if (!dict.ContainsKey(item))
        {
            dict.Add(item, 1);
        }
        else
        {
            dict[item]++;
        }
    }

    foreach (var item in ransomNote)
    {
        if (dict.ContainsKey(item) && dict[item] > 0)
        {
            dict[item]--;
        } 
        else
        {
            return false;
        }
    }
    return true;
}