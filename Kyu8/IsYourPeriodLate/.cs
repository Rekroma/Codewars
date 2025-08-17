using System;

namespace Kyu8.IsYourPeriodLate;

public static class Kata
{
    public static bool PeriodIsLate(DateTime last, DateTime today, int cycleLength)
    {
        return today > last.AddDays(cycleLength);
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 35), Is.EqualTo(false));
        Assert.That(Kata.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 28), Is.EqualTo(true));
        Assert.That(Kata.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 07, 16), 35), Is.EqualTo(false));
        Assert.That(Kata.PeriodIsLate(new DateTime(2016, 06, 13), new DateTime(2016, 06, 29), 28), Is.EqualTo(false));
        Assert.That(Kata.PeriodIsLate(new DateTime(2016, 07, 12), new DateTime(2016, 08, 09), 28), Is.EqualTo(false));
        Assert.That(Kata.PeriodIsLate(new DateTime(2016, 07, 12), new DateTime(2016, 08, 10), 28), Is.EqualTo(true));
        Assert.That(Kata.PeriodIsLate(new DateTime(2016, 07, 01), new DateTime(2016, 08, 01), 28), Is.EqualTo(true));
        Assert.That(Kata.PeriodIsLate(new DateTime(2016, 06, 01), new DateTime(2016, 06, 30), 30), Is.EqualTo(false));
        Assert.That(Kata.PeriodIsLate(new DateTime(2016, 01, 01), new DateTime(2016, 01, 31), 30), Is.EqualTo(false));
        Assert.That(Kata.PeriodIsLate(new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), 30), Is.EqualTo(true));
        Assert.That(Kata.PeriodIsLate(new DateTime(2020, 06, 01), new DateTime(2020, 07, 01), 40), Is.EqualTo(false));
        Assert.That(Kata.PeriodIsLate(new DateTime(2020, 06, 01), new DateTime(2020, 06, 30), 30), Is.EqualTo(false));
        Assert.That(Kata.PeriodIsLate(new DateTime(2020, 06, 12), new DateTime(2020, 07, 12), 28), Is.EqualTo(true));
        Assert.That(Kata.PeriodIsLate(new DateTime(2000, 01, 01), new DateTime(2000, 01, 01), 28), Is.EqualTo(false));
        Assert.That(Kata.PeriodIsLate(new DateTime(2022, 01, 01), new DateTime(2022, 02, 01), 30), Is.EqualTo(true));
        Assert.That(Kata.PeriodIsLate(new DateTime(2022, 01, 01), new DateTime(2022, 02, 01), 40), Is.EqualTo(false));
    }
}