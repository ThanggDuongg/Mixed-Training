int[] FindArray(int[] pref)
{
    var result = new int[pref.Length];
    result[0] = pref[0];
    for (int i = 1; i < pref.Length; i++)
    {
        result[i] = pref[i-1] ^ pref[i];
    }
    return result;
}

var x = FindArray(new[] { 5, 2, 0, 3, 1 });