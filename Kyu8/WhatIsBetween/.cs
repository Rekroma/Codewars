using System.Linq;

namespace Kyu8.WhatIsBetween;

public class Kata
{
    public static int[] Between(int a, int b)
    {
        return Enumerable.Range(a, b - a + 1).ToArray();
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Between(0, 3), Is.EqualTo(new int[] { 0, 1, 2, 3 }));
        Assert.That(Kata.Between(-2, 2), Is.EqualTo(new int[] { -2, -1, 0, 1, 2 }));
        Assert.That(Kata.Between(-10, 10), Is.EqualTo(new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
    }
}