int diagonalDifference(List<List<int>> arr)
{
    int left = 0, right = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        left += arr[i][i];
        right += arr[i][arr.Count - 1 - i];
    }

    return Math.Abs(left - right);
}