using System.Text.RegularExpressions;

namespace Kyu7.PasswordValidator;

public class PasswordValidator
{
    public static bool Password(string st)
    {
        return Regex.IsMatch(st, "(?=.{8,})(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)");
    }
}


[TestFixture]
public class ExampleTests
{
    [Test, Order(1)]
    [Description("Valid passwords")]
    public void TestValidPasswords()
    {
        DoTest("Abcd1234", true);
        DoTest("AbcdefGhijKlmnopQRsTuvwxyZ1234567890", true);
        DoTest("Ab1!@#$%^&*()-_+={}[]|:;?/>.<,", true);
        DoTest(" aA1----", true);
        DoTest("4aA1----", true);
    }

    [Test, Order(2)]
    [Description("Too short passwords")]
    public void TestTooShortPasswords()
    {
        DoTest("Abcd123", false);
    }

    [Test, Order(2)]
    [Description("Missing uppercase letters")]
    public void TestMissingUppercaseLetters()
    {
        DoTest("abcd1234", false);
    }

    [Test, Order(2)]
    [Description("Missing digits")]
    public void TestMissingDigits()
    {
        DoTest("abcdABCD", false);
    }

    [Test, Order(2)]
    [Description("Missing lowercase letters")]
    public void TestMissingLowercaseLetters()
    {
        DoTest("ABCD1234", false);
    }

    [Test, Order(2)]
    [Description("Only special characters")]
    public void TestOnlySpecialCharacters()
    {
        DoTest("!@#$%^&*()-_+={}[]|:;?/>.<,", false);
    }

    [Test, Order(2)]
    [Description("Empty password")]
    public void TestEmptyPassword()
    {
        DoTest("", false);
    }

    private void DoTest(string password, bool expected)
    {
        Assert.That(PasswordValidator.Password(password), Is.EqualTo(expected), $"Expected {expected} for password \"{password}\".");
    }
}