namespace Kyu8.CenturyFromYear;

public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        return (year - 1) / 100 + 1;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.СenturyFromYear(1705), Is.EqualTo(18));
        Assert.That(Kata.СenturyFromYear(1900), Is.EqualTo(19));
        Assert.That(Kata.СenturyFromYear(1601), Is.EqualTo(17));
        Assert.That(Kata.СenturyFromYear(2000), Is.EqualTo(20));
    }
}