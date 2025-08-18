using System;
using System.Linq;

namespace Kyu7.BeginnerSeriesThreeSumOfNumbers;

public class Sum
{
    public int GetSum(int a, int b)
    {
        return Enumerable.Range(Math.Min(a, b), Math.Max(a, b) - Math.Min(a, b) + 1).Sum();
    }
}


[TestFixture]
public class SumTest1
{
    Sum s = new Sum();

    [Test]
    public void Test1()
    {
        Assert.That(s.GetSum(0, 1), Is.EqualTo(1));
        Assert.That(s.GetSum(0, -1), Is.EqualTo(-1));
    }
}