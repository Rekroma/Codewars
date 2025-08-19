using System;
using System.Linq;

namespace Kyu6.BitCounting;

public class Kata
{
    public static int CountBits(int n)
    {
        return Convert.ToString(n, 2).Count(c => c == '1');
    }
}


[TestFixture]
public class BitCounting
{
    private static void DoTest(int input, int expected)
    {
        int actual = Kata.CountBits(input);
        Assert.That(actual, Is.EqualTo(expected), "for n = " + input);
    }

    [Test, Order(1)]
    public void FixedTests()
    {
        DoTest(0, 0);
        DoTest(4, 1);
        DoTest(7, 3);
        DoTest(12525589, 11);
        DoTest(3811, 8);
        DoTest(392902058, 17);
        DoTest(1044, 3);
        DoTest(10030245, 10);
        DoTest(89, 4);
        DoTest(674259, 10);
        DoTest(Int32.MaxValue, 31);
    }
}