using System;

namespace Kyu6.EnglishBeggars;

public class Kata
{
    public static int[] Beggars(int[] values, int n)
    {
        if (n <= 0) return Array.Empty<int>();

        int[] result = new int[n];

        for (int i = 0; i < values.Length; i++) result[i % n] += values[i];

        return result;
    }
}


public class SolutionTest
{
    [Test]
    public void FixedTest()
    {
        // Basic tests
        int[] test = { 1, 2, 3, 4, 5 };
        int[] a1 = { 15 }, a2 = { 9, 6 }, a3 = { 5, 7, 3 }, a4 = { 1, 2, 3, 4, 5, 0 }, a5 = { };
        Assert.That(Kata.Beggars(test, 1), Is.EqualTo(a1));
        Assert.That(Kata.Beggars(test, 2), Is.EqualTo(a2));
        Assert.That(Kata.Beggars(test, 3), Is.EqualTo(a3));
        Assert.That(Kata.Beggars(test, 6), Is.EqualTo(a4));
        Assert.That(Kata.Beggars(test, 0), Is.EqualTo(a5));
    }
}