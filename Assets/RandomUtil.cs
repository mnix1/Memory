using System.Collections.Generic;
using System;

public static class RandomUtil
{
    private static Random random = new Random();

    public static T RandomElement<T>(List<T> list)
    {
        return list[random.Next(list.Count)];
    }
}
