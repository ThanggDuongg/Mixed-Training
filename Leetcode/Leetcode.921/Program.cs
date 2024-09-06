int MinAddToMakeValid(string s)
{
    var countOpen = 0;
    var countClose = 0;
    foreach (var item in s)
    {
        if (item == '(')
        {
            countOpen++;
        } else if (item == ')')
        {
            countClose++;
        } 
    }
    return countOpen > countClose ? countOpen - countClose : countClose - countOpen;
}