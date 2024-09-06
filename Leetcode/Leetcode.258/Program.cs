int AddDigits(int num)
{
    if (num < 10) return num;

    while (num >= 10)
    {
        num = num.ToString().Select(x => x - '0').Sum();
    } 
    return num;
}