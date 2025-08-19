using System.Text.RegularExpressions;

namespace Kyu7.RegexValidatePinCode;

public class Kata
{
    public static bool ValidatePin(string pin)
    {
        return Regex.IsMatch(pin, @"^\d{4}\z|^\d{6}\z");
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1), Description("ValidatePin should return false for pins with length other than 4 or 6")]
    public void LengthTest()
    {
        Assert.That(Kata.ValidatePin("1"), Is.False, "Wrong output for \"1\"");
        Assert.That(Kata.ValidatePin("12"), Is.False, "Wrong output for \"12\"");
        Assert.That(Kata.ValidatePin("123"), Is.False, "Wrong output for \"123\"");
        Assert.That(Kata.ValidatePin("12345"), Is.False, "Wrong output for \"12345\"");
        Assert.That(Kata.ValidatePin("1234567"), Is.False, "Wrong output for \"1234567\"");
        Assert.That(Kata.ValidatePin("-1234"), Is.False, "Wrong output for \"-1234\"");
        Assert.That(Kata.ValidatePin("1.234"), Is.False, "Wrong output for \"1.234\"");
        Assert.That(Kata.ValidatePin("-1.234"), Is.False, "Wrong output for \"-1.234\"");
        Assert.That(Kata.ValidatePin("00000000"), Is.False, "Wrong output for \"00000000\"");
    }

    [Test, Order(2), Description("ValidatePin should return false for pins which contain characters other than digits")]
    public void NonDigitTest()
    {
        Assert.That(Kata.ValidatePin("a234"), Is.False, "Wrong output for \"a234\"");
        Assert.That(Kata.ValidatePin(".234"), Is.False, "Wrong output for \".234\"");
    }

    [Test, Order(3), Description("ValidatePin should return true for valid pins")]
    public void ValidTest()
    {
        Assert.That(Kata.ValidatePin("1234"), Is.True, "Wrong output for \"1234\"");
        Assert.That(Kata.ValidatePin("0000"), Is.True, "Wrong output for \"0000\"");
        Assert.That(Kata.ValidatePin("1111"), Is.True, "Wrong output for \"1111\"");
        Assert.That(Kata.ValidatePin("123456"), Is.True, "Wrong output for \"123456\"");
        Assert.That(Kata.ValidatePin("098765"), Is.True, "Wrong output for \"098765\"");
        Assert.That(Kata.ValidatePin("000000"), Is.True, "Wrong output for \"000000\"");
        Assert.That(Kata.ValidatePin("090909"), Is.True, "Wrong output for \"090909\"");
    }
}