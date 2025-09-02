using System;

namespace Kyu8.EnumerableMagicTwoFive;

public static class Kata
{
    public static int[] Take(int[] arr, int n)
    {
        return arr.Take(n).ToArray();
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 3), Is.EqualTo(new int[] { 0, 1, 2 }));
        Assert.That(Kata.Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 0), Is.EqualTo(new int[] { }));
        Assert.That(Kata.Take(new int[] { }, 3), Is.EqualTo(new int[] { }));
    }
}