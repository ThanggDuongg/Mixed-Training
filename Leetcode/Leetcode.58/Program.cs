int LengthOfLastWord(string s)
{
    return s.TrimEnd().Split(" ")[^1].Length;
}

LengthOfLastWord("Today is a nice day");