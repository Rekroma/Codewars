using System.Text.RegularExpressions;

namespace Kyu8.RegexCountLowercaseLetters;

public class Kata
{
    public static int LowercaseCountCheck(string s)
    {
        return Regex.Matches(s, "[a-z]").Count;
    }
}


public class Tests
{
    [Test]
    [TestCase("abc", ExpectedResult = 3)]
    [TestCase("abcABC123", ExpectedResult = 3)]
    [TestCase("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~", ExpectedResult = 3)]
    [TestCase("", ExpectedResult = 0)]
    [TestCase("ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~", ExpectedResult = 0)]
    [TestCase("abcdefghijklmnopqrstuvwxyz", ExpectedResult = 26)]
    public static int FixedTest(string str)
    {
        return Kata.LowercaseCountCheck(str);
    }
}