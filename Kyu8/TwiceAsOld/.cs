using System;

namespace Kyu8.TwiceAsOld;

public class TwiceAsOldSolution
{
    public static int TwiceAsOld(int dadYears, int sonYears)
    {
        return Math.Abs(dadYears - sonYears * 2);
    }
}


[TestFixture]
public class TwiceAsOldTest
{
    [Test]
    public void SampleTests()
    {
        Assert.That(TwiceAsOldSolution.TwiceAsOld(30, 0), Is.EqualTo(30));
        Assert.That(TwiceAsOldSolution.TwiceAsOld(30, 7), Is.EqualTo(16));
        Assert.That(TwiceAsOldSolution.TwiceAsOld(45, 30), Is.EqualTo(15));
    }
}