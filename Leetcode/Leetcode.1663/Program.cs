string GetSmallestString(int n, int k)
{
    //string result = new string('a', n);
    var arr = Enumerable.Repeat(26, n).ToArray();
    for (int i = n - 1; i >= 0; i--)
    {
        arr[i] = Math.Min(arr[i], k);
        k -= Math.Min(arr[i], k);
    }

}