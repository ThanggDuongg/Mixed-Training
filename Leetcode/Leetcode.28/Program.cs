int StrStr(string haystack, string needle)
{
    if (needle.Length > haystack.Length)
    {
        return -1;
    }
    if (needle.Length == haystack.Length && needle == haystack) 
    {
        return 0;
    }

    var firstChar = needle[0];
    var charIndexes = new List<int>();
    for (int i = 0; i < haystack.Length; i++)
    {
        if (haystack[i] == firstChar)
        {
            charIndexes.Add(i);
        }
    }

    foreach (var charIndex in charIndexes)
    {
        if (haystack[charIndex..].Length >= needle.Length)
        {
            if (haystack.Substring(charIndex, needle.Length) == needle)
            {
                return charIndex;
            }
        } 
        else
        {

            return -1;
        }
    }

    return -1;
}

StrStr("abc", "c");