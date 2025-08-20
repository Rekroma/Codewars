using System.Text.RegularExpressions;

namespace Kyu7.CountConsonants;

public class Kata
{
    public static int ConsonantCount(string str)
    {
        return Regex.Matches(str, "[b-df-hj-np-tv-z]", RegexOptions.IgnoreCase).Count;
    }
}


[TestFixture]
public class Tests
{
    [Test, Order(1)]
    [TestCase("", ExpectedResult = 0)]
    [TestCase("aaaaa", ExpectedResult = 0)]
    [TestCase("Bbbbb", ExpectedResult = 5)]
    [TestCase("helLo world", ExpectedResult = 7)]
    [TestCase("h^$&^#$&^elLo world", ExpectedResult = 7)]
    [TestCase("012456789", ExpectedResult = 0)]
    [TestCase("012345_Cb", ExpectedResult = 2)]
    public static int FixedTest(string s)
    {
        return Kata.ConsonantCount(s);
    }
}