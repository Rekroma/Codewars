using System;
using System.Linq;

namespace Kyu8.SumMixedArrays;

public class Kata
{
    public static int SumMix(object[] x)
    {
        return x.Sum(Convert.ToInt32);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        Assert.That(Kata.SumMix(new object[] { 9, 3, "7", "3" }), Is.EqualTo(22));
        Assert.That(Kata.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }), Is.EqualTo(42));
        Assert.That(Kata.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }), Is.EqualTo(41));
    }
}