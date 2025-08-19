using System;

namespace Kyu7.FunctionalAddition;

public static class Kata
{
    public static Func<double, double> Add(double n)
    {
        return x => x + n;
    }
}