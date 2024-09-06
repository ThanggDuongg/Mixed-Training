bool IsAnagram(string s, string t)
{
    return String.Concat(s.OrderBy(x => x)) == String.Concat(t.OrderBy(x => x));
}