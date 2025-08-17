using System.Text.RegularExpressions;

namespace Kyu8.SimpleValidationOfAUsernameWithRegex;

public class Kata
{
    public static bool ValidateUsr(string username)
    {
        return Regex.IsMatch(username, @"\A[a-z0-9_]{4,16}\z");
    }
}


public class Tests
{
    [Test]
    [TestCase("asddsa", ExpectedResult = true)]
    [TestCase("a", ExpectedResult = false)]
    [TestCase("Hass", ExpectedResult = false)]
    [TestCase("Hasd_12ssssssssssssssasasasasasssasassss", ExpectedResult = false)]
    [TestCase("", ExpectedResult = false)]
    [TestCase("____", ExpectedResult = true)]
    [TestCase("012", ExpectedResult = false)]
    [TestCase("p1pp1", ExpectedResult = true)]
    [TestCase("asd43 34", ExpectedResult = false)]
    [TestCase("asd43_34", ExpectedResult = true)]
    public static bool FixedTest(string username)
    {
        return Kata.ValidateUsr(username);
    }
}