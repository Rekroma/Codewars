using System.Linq;

namespace Kyu7.FilterTheNumber;

public class Kata
{
    public static int FilterString(string s)
    {
        return int.Parse(string.Join("", s.Where(char.IsDigit).Select(c => c - '0')));
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public static void FixedTests()
    {
        Assert.That(Kata.FilterString("123"), Is.EqualTo(123), "Just return the numbers");
        Assert.That(Kata.FilterString("a1b2c3"), Is.EqualTo(123), "Just return the numbers");
        Assert.That(Kata.FilterString("aa1bb2cc3dd"), Is.EqualTo(123), "Just return the numbers");
    }
}