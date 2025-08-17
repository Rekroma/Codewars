using System;

namespace Kyu8.CompareWithMargin;

public class Kata
{
    public static int CloseCompare(double a, double b, double margin = 0)
    {
        return (Math.Abs(a - b) <= margin) ? 0 : (a < b ? -1 : 1);
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.CloseCompare(4, 5), Is.EqualTo(-1));
        Assert.That(Kata.CloseCompare(5, 5), Is.EqualTo(0));
        Assert.That(Kata.CloseCompare(6, 5), Is.EqualTo(1));
        Assert.That(Kata.CloseCompare(-6, -5), Is.EqualTo(-1));

        Assert.That(Kata.CloseCompare(2, 5, 3), Is.EqualTo(0));
        Assert.That(Kata.CloseCompare(8.1, 5, 3), Is.EqualTo(1));
        Assert.That(Kata.CloseCompare(1.99, 5, 3), Is.EqualTo(-1));
    }
}