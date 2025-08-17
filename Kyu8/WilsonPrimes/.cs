namespace Kyu8.WilsonPrimes;

public class Kata
{
    public static bool AmIWilson(int p)
    {
        return p == 5 || p == 13 || p == 563;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [TestCase(5, ExpectedResult = true)]
    [TestCase(9, ExpectedResult = false)]
    [TestCase(6, ExpectedResult = false)]
    public static bool FixedTest(int p)
    {
        return Kata.AmIWilson(p);
    }
}