using System;

namespace Kyu7.ConsecutiveItems;

public static class Kata
{
    public static bool Consecutive(int[] arr, int a, int b)
    {
        return Array.IndexOf(arr, a) + 1 == Array.IndexOf(arr, b) || Array.IndexOf(arr, b) + 1 == Array.IndexOf(arr, a);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Kata.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 7), Is.EqualTo(false));
        Assert.That(Kata.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 1), Is.EqualTo(true));
        Assert.That(Kata.Consecutive(new int[] { 1, 6, 9, -3, 4, -78, 0 }, -3, 4), Is.EqualTo(true));
    }
}