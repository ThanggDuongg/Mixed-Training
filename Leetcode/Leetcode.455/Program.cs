int FindContentChildren(int[] g, int[] s)
{
    Array.Sort(g);
    Array.Sort(s);

    var i = 0;
    var j = 0;
    while (j < s.Length && i < g.Length)
    {
        if (s[j] >= g[i])
        {
            i++;
        }
        j++;
    }
    return i;
}       