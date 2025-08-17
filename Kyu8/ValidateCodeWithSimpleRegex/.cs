using System.Text.RegularExpressions;

namespace Kyu8.ValidateCodeWithSimpleRegex;

public class Kata
{
    public static bool ValidateCode(string code)
    {
        return Regex.IsMatch(code, @"\A(1|2|3)");
    }
}


public class Tests
{
    [Test]
    [TestCase("123", ExpectedResult = true)]
    [TestCase("248", ExpectedResult = true)]
    [TestCase("8", ExpectedResult = false)]
    [TestCase("321", ExpectedResult = true)]
    [TestCase("9453", ExpectedResult = false)]
    public static bool FixedTest(string code)
    {
        return Kata.ValidateCode(code);
    }
}