using System;

namespace Kyu7.YoureASquare;

public class Kata
{
    public static bool IsSquare(int n)
    {
        return n > 0 && Math.Sqrt(n) == Math.Round(Math.Sqrt(n)) || n == 0; ;
    }
}


[TestFixture]
public class Tests
{
    [Test, Order(1)]
    public static void ShouldWorkForSomeExamples()
    {
        Assert.That(Kata.IsSquare(-1), Is.False, "negative numbers aren't square numbers");
        Assert.That(Kata.IsSquare(3), Is.False, "3 isn't a square number");
        Assert.That(Kata.IsSquare(4), Is.True, "4 is a square number");
        Assert.That(Kata.IsSquare(25), Is.True, "25 is a square number");
        Assert.That(Kata.IsSquare(26), Is.False, "26 isn't a square number");
    }
}