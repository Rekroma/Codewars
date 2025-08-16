using System;

namespace Kyu8.BinToDecimal;

public static class Program
{
    public static int binToDec(string s)
    {
        return Convert.ToInt32(s, 2);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Program.binToDec("0"), Is.EqualTo(0));
        Assert.That(Program.binToDec("1"), Is.EqualTo(1));
        Assert.That(Program.binToDec("10"), Is.EqualTo(2));
        Assert.That(Program.binToDec("11"), Is.EqualTo(3));
        Assert.That(Program.binToDec("110"), Is.EqualTo(6));
    }
}