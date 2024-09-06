string AddBinary(string a, string b)
{
    return Convert.ToString((Convert.(a, 2) + Convert.ToInt32(b, 2)), 2);
}