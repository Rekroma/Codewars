using System;
using System.Linq;

namespace Kyu7.AverageScore;

public class Kata
{
    public static int Average(int[] scores)
    {
        return (int)Math.Round(scores.Average());
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        var scores = new int[] { 49, 3, 5, 300, 7 };
        Assert.That(Kata.Average(scores), Is.EqualTo(73));

        scores = new int[] { 90, 98, 89, 100, 100, 86, 94 };
        Assert.That(Kata.Average(scores), Is.EqualTo(94));
    }
}