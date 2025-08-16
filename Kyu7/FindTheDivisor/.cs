using System.Collections.Generic;

namespace Kyu7.FindTheDivisor;

public class Kata
{
    public static int[] Divisors(int n)
    {
        var divisors = new List<int>();

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0) divisors.Add(i);
        }

        return divisors.Count != 0 ? divisors.ToArray() : null;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Divisors(15), Is.EqualTo(new int[] { 3, 5 }), "n = 15");
        Assert.That(Kata.Divisors(16), Is.EqualTo(new int[] { 2, 4, 8 }), "n = 16");
        Assert.That(Kata.Divisors(253), Is.EqualTo(new int[] { 11, 23 }), "n = 253");
        Assert.That(Kata.Divisors(24), Is.EqualTo(new int[] { 2, 3, 4, 6, 8, 12 }), "n = 24");
        Assert.That(Kata.Divisors(7), Is.Null, "n = 7");
    }
}