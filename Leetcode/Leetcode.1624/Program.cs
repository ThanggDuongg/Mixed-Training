int MaxLengthBetweenEqualCharacters(string s)
{
    var dict = new Dictionary<char, int>();
	var max = -1;
	for (int i = 0; i < s.Length; i++)
	{
		if (!dict.ContainsKey(s[i]))
		{
			dict.Add(s[i], i);
		}
		else
		{
			var firstIndex = dict[s[i]];
			if (i - 1 - firstIndex > max)
			{
				max = i - 1 - firstIndex;
			}
		}
	}
	return max;
}