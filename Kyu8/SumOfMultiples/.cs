using System;
using System.Linq;

namespace Kyu8.SumOfMultiples;

public class Kata
{
    public static int SumMul(int n, int m)
    {
        if (n < 1 || m <= n)
        {
            throw new ArgumentException();
        }

        return Enumerable.Range(n, m - n).Where(x => x % n == 0).Sum();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Should produce expected results for valid inputs")]
    [Order(1)]
    public void SampleTest()
    {
        Assert.That(Kata.SumMul(2, 9), Is.EqualTo(20), "n = 2, m = 9");
        Assert.That(Kata.SumMul(5, 20), Is.EqualTo(30), "n = 5, m = 20");
        Assert.That(Kata.SumMul(4, 123), Is.EqualTo(1860), "n = 4, m = 123");
        Assert.That(Kata.SumMul(123, 4567), Is.EqualTo(86469), "n = 123, m = 4567");
    }

    [Test, Description("Should throw for invalid inputs")]
    [Order(2)]
    public void ErrorTest()
    {
        Assert.That(() => Kata.SumMul(4, 1), Throws.TypeOf<ArgumentException>(), "n = 4, m = 1");
        Assert.That(() => Kata.SumMul(0, 20), Throws.TypeOf<ArgumentException>(), "n = 0, m = 20");
    }
}