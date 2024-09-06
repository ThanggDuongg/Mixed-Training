bool IsHappy(int n)
{
    var numString = n.ToString();
    int sum = 0;
    var existed = new List<int>();
    
    while (sum != 1 && sum != 7)
    {
        sum = numString.Select(x =>
        {
            var toNum = x - '0';
            return toNum * toNum;
        }).Sum();
        
        if (sum == 1 || sum == 7)
        {
            return true;
        }

        if (existed.Contains(sum))
        {
            return false;
        } else
        {
            existed.Add(sum);
            numString = sum.ToString();
        }
    }

    return true; // sum == 1;
}

IsHappy(19);