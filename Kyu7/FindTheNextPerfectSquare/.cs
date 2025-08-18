using System;

namespace Kyu7.FindTheNextPerfectSquare;

public class Kata
{
    public static long FindNextSquare(long num)
    {
        long sqrt = (long)Math.Sqrt(num);
        if (sqrt * sqrt != num) return -1;
        return (sqrt + 1) * (sqrt + 1);
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [TestCase(155, ExpectedResult = -1)]
    [TestCase(121, ExpectedResult = 144)]
    [TestCase(625, ExpectedResult = 676)]
    [TestCase(319225, ExpectedResult = 320356)]
    [TestCase(15241383936, ExpectedResult = 15241630849)]
    public static long SampleTests(long num)
    {
        return Kata.FindNextSquare(num);
    }
}