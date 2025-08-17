using System.Text.RegularExpressions;

namespace Kyu8.RegexpBasicsIsItADigit;

public static class Kata
{
    public static bool Digit(this string s)
    {
        return s.Length == 1 && Regex.IsMatch(s, @"^\d$");
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That("".Digit(), Is.EqualTo(false));
        Assert.That("7".Digit(), Is.EqualTo(true));
        Assert.That(" ".Digit(), Is.EqualTo(false));
        Assert.That("a".Digit(), Is.EqualTo(false));
        Assert.That("a5".Digit(), Is.EqualTo(false));
        Assert.That("14".Digit(), Is.EqualTo(false));
    }
}
