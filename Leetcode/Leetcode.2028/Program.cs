int[] MissingRolls(int[] rolls, int mean, int n)
{
    var totalRolls = rolls.Length + n;
    var totalValue = mean * totalRolls;
    var totalMissing = totalValue - rolls.Sum();

    if (totalMissing < n || totalMissing > 6 * n)
    {
        return Array.Empty<int>();
    }

    int equalShare = totalMissing / n;
    int remainder = totalMissing % n;
    var result = new int[n];
    Array.Fill(result, equalShare);

    for (int i = 0; i < n; i++)
    {
        result[i] += (remainder > i ? 1 : 0);
    }

    return result;
}