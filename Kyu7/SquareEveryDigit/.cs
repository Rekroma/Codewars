using System;
using System.Linq;

namespace Kyu7.SquareEveryDigit;

public class Kata
{
    public static int SquareDigits(int n)
    {
        return int.Parse(string.Join("", n.ToString().Select(x => Math.Pow(x - '0', 2))));
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void SquareDigitsTest()
    {
        Assert.That(Kata.SquareDigits(9119), Is.EqualTo(811181), "Incorrect answer for n=9119");
        Assert.That(Kata.SquareDigits(0), Is.EqualTo(0), "Incorrect answer for n=0");
    }
}