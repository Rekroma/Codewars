using System;

namespace Kyu7.SumOfCubes;

public static class Kata
{
    public static long SumCubes(int n)
    {
        return (long)Math.Pow(n * (n + 1) / 2, 2);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        Assert.That(Kata.SumCubes(1), Is.EqualTo(1));
        Assert.That(Kata.SumCubes(2), Is.EqualTo(9));
        Assert.That(Kata.SumCubes(3), Is.EqualTo(36));
        Assert.That(Kata.SumCubes(4), Is.EqualTo(100));
        Assert.That(Kata.SumCubes(10), Is.EqualTo(3025));
        Assert.That(Kata.SumCubes(123), Is.EqualTo(58155876));
    }
}