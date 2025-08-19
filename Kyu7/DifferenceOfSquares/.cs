using System.Linq;

namespace Kyu7.DifferenceOfSquares;

public class Kata
{
    public static int DifferenceOfSquares(int n)
    {
        return Enumerable.Range(1, n).Sum() * Enumerable.Range(1, n).Sum() - Enumerable.Range(1, n).Select(x => x * x).Sum();
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [TestCase(5, ExpectedResult = 170)]
    [TestCase(10, ExpectedResult = 2640)]
    [TestCase(100, ExpectedResult = 25164150)]
    public static int FixedTest(int x)
    {
        return Kata.DifferenceOfSquares(x);
    }
}