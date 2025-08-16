using System;

namespace Kyu8.NbaFullFourEightMinutesAverage;

public class Kata
{
    public static double NbaExtrap(double ppg, double mpg)
    {
        return (mpg == 0) ? 0 : Math.Round((ppg / mpg) * 48, 1);
    }
}


[TestFixture]
public class Sample_Tests
{
    [Test]
    public void Test()
    {
        Assert.That(Kata.NbaExtrap(12, 20), Is.EqualTo(28.8));
        Assert.That(Kata.NbaExtrap(10, 10), Is.EqualTo(48.0));
        Assert.That(Kata.NbaExtrap(5, 17), Is.EqualTo(14.1));
        Assert.That(Kata.NbaExtrap(0, 0), Is.EqualTo(0));
        Assert.That(Kata.NbaExtrap(30.8, 34.7), Is.EqualTo(42.6));
        Assert.That(Kata.NbaExtrap(22.9, 33.8), Is.EqualTo(32.5));
    }
}