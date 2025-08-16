namespace Kyu8.CountOddNumbersBelowN;

public static class Kata
{
    public static ulong OddCount(ulong n)
    {
        return n / 2;
    }
}


[TestFixture]
public class SampleTest
{
    [Test]
    public void Test()
    {
        Assert.That(Kata.OddCount(15), Is.EqualTo(7));
        Assert.That(Kata.OddCount(15023), Is.EqualTo(7511));
    }
}