bool IsValid(string s)
{
    var stack = new Stack<char>();
    foreach (var item in s)
    {
        if (item == '(' || item == '[' || item == '{')
        {
            stack.Push(item);
        }
        else
        {
            var hasValue = stack.TryPop(out char flag);
            if (!(item - flag == 1 || item - flag == 2) || !hasValue)
            {
                return false;
            }
        }
    }
    return stack.Count == 0;
}

IsValid("(");