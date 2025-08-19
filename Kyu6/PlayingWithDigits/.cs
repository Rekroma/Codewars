using System;
using System.Linq;

namespace Kyu6.PlayingWithDigits;

public class DigPow
{
    public static long digPow(int n, int p)
    {
        long sum = n.ToString().Select((digit, index) => (long)Math.Pow(digit - '0', p + index)).Sum();

        return sum % n == 0 ? sum / n : -1;
    }
}


[TestFixture]
public class DigPowTests
{
    [Test, Description("digPow(89, 1)")]
    [Order(1)]
    public void Test1()
    {
        Assert.That(DigPow.digPow(89, 1), Is.EqualTo(1));
    }

    [Test, Description("digPow(92, 1)")]
    [Order(2)]
    public void Test2()
    {
        Assert.That(DigPow.digPow(92, 1), Is.EqualTo(-1));
    }

    [Test, Description("digPow(46288, 3)")]
    [Order(3)]
    public void Test3()
    {
        Assert.That(DigPow.digPow(46288, 3), Is.EqualTo(51));
    }
}