using System;

namespace Kyu4.NextBiggerNumberWithTheSameDigits;

public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        char[] digits = n.ToString().ToCharArray();

        int i = digits.Length - 2;
        while (i >= 0 && digits[i] >= digits[i + 1]) i--;

        if (i < 0) return -1;

        int j = digits.Length - 1;
        while (digits[j] <= digits[i]) j--;

        (digits[i], digits[j]) = (digits[j], digits[i]);

        Array.Reverse(digits, i + 1, digits.Length - (i + 1));

        return long.Parse(new string(digits));
    }
}


[TestFixture]
public class NextBiggerNumberTests
{
    [Test]
    public void SmallNumbers()
    {
        Assert.That(Kata.NextBiggerNumber(12), Is.EqualTo(21));
        Assert.That(Kata.NextBiggerNumber(513), Is.EqualTo(531));
        Assert.That(Kata.NextBiggerNumber(2017), Is.EqualTo(2071));
        Assert.That(Kata.NextBiggerNumber(414), Is.EqualTo(441));
        Assert.That(Kata.NextBiggerNumber(144), Is.EqualTo(414));
    }
}
