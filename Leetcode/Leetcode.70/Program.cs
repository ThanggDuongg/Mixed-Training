﻿int ClimbStairs(int n)
{
    int a = 1, b = 1, c = 1;

    for (int i = 2; i < n + 1; i++)
    {
        c = a + b;
        a = b;
        b = c;
    }

    return c;
}