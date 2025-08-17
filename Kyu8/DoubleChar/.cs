using System.Linq;

namespace Kyu8.DoubleChar;

public class Kata
{
    public static string DoubleChar(string s)
    {
        return string.Join("", s.Select(x => "" + x + x));
    }
}


[TestFixture]
public class Test
{
    [Test]
    [TestCase("abcd", ExpectedResult = "aabbccdd")]
    [TestCase("Adidas", ExpectedResult = "AAddiiddaass")]
    [TestCase("1337", ExpectedResult = "11333377")]
    [TestCase("illuminati", ExpectedResult = "iilllluummiinnaattii")]
    [TestCase("123456", ExpectedResult = "112233445566")]
    [TestCase("%^&*(", ExpectedResult = "%%^^&&**((")]
    public static string FixedTest(string s)
    {
        return Kata.DoubleChar(s);
    }
}