namespace Kyu8.GrasshopperCheckForFactor;

public class Kata
{
    public static bool CheckForFactor(int num, int factor)
    {
        return num % factor == 0;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [TestCase(10, 2, true)]
    [TestCase(63, 7, true)]
    [TestCase(2450, 5, true)]
    [TestCase(24612, 3, true)]
    [TestCase(9, 2, false)]
    [TestCase(653, 7, false)]
    [TestCase(2453, 5, false)]
    [TestCase(24617, 3, false)]
    public static void FixedTest(int num, int factor, bool isFactor)
    {
        Assert.That(Kata.CheckForFactor(num, factor), Is.EqualTo(isFactor));
    }
}