using System.Linq;

namespace Kyu8.StringyStrings;

public class Kata
{
    public static string Stringy(int size)
    {
        return string.Concat(Enumerable.Range(0, size).Select(i => i % 2 == 0 ? "1" : "0"));
    }
}


[TestFixture]
public class Tests
{
    [TestCase(1, ExpectedResult = "1")]
    [TestCase(2, ExpectedResult = "10")]
    [TestCase(10, ExpectedResult = "1010101010")]
    public static string FixedTest(int size)
    {
        return Kata.Stringy(size);
    }
}
