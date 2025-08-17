using System;

namespace Kyu8.HexToDecimal;

public class Kata
{
    public static int HexToDec(string hexString)
    {
        return Convert.ToInt32(hexString.TrimStart('-'), 16) * (hexString[0] == '-' ? -1 : 1);
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.HexToDec("1"), Is.EqualTo(1));
        Assert.That(Kata.HexToDec("a"), Is.EqualTo(10));
        Assert.That(Kata.HexToDec("10"), Is.EqualTo(16));
        Assert.That(Kata.HexToDec("FF"), Is.EqualTo(255));
        Assert.That(Kata.HexToDec("-C"), Is.EqualTo(-12));
    }
}