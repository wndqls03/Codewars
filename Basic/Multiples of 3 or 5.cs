﻿public static class Kata
{
    public static int Solution(int value)
    {
        int res = 0;
        for (int i = 0; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                res += i;
            }
        }
        return res;
    }
}