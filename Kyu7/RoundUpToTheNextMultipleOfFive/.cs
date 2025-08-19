namespace Kyu7.RoundUpToTheNextMultipleOfFive;

public class Kata
{
    public static int RoundToNext5(int n)
    {
        while (n % 5 != 0) n++;
        return n;
    }
}


[TestFixture]
public class Tests
{
    [TestCase(0, ExpectedResult = 0)]
    [TestCase(1, ExpectedResult = 5)]
    [TestCase(3, ExpectedResult = 5)]
    [TestCase(5, ExpectedResult = 5)]
    [TestCase(7, ExpectedResult = 10)]
    [TestCase(39, ExpectedResult = 40)]
    public static int FixedTest(int n)
    {
        return Kata.RoundToNext5(n);
    }
}
