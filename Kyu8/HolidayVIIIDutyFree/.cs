namespace HolidayVIIIDutyFree;

public class Kata
{
    public static int DutyFree(int normPrice, int Discount, int hol)
    {
        return (int)(hol / (normPrice * (Discount / 100.0)));
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.DutyFree(12, 50, 1000), Is.EqualTo(166));
        Assert.That(Kata.DutyFree(17, 10, 500), Is.EqualTo(294));
        Assert.That(Kata.DutyFree(24, 35, 3000), Is.EqualTo(357));
    }
}