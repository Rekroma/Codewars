using System;
using System.Linq;

namespace Kyu7.DivideAndConquer;

public class Kata
{
    public static int DivCon(Object[] objArray)
    {
        return objArray.OfType<int>().Sum() - objArray.OfType<string>().Select(x => int.Parse(x)).Sum();
    }
}


[TestFixture]
public class SpacifyTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        Assert.That(Kata.DivCon(new object[] { 9, 3, "7", "3" }), Is.EqualTo(2));
        Assert.That(Kata.DivCon(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }), Is.EqualTo(14));
        Assert.That(Kata.DivCon(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }), Is.EqualTo(13));
        Assert.That(Kata.DivCon(new object[] { "1", "5", "8", 8, 9, 9, 2, "3" }), Is.EqualTo(11));
        Assert.That(Kata.DivCon(new object[] { 8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7 }), Is.EqualTo(61));
        Assert.That(Kata.DivCon(new object[] { "0", "1", "2", "3" }), Is.EqualTo(-6));
        Assert.That(Kata.DivCon(new object[] { 0, 1, 2, 3 }), Is.EqualTo(6));
        Assert.That(Kata.DivCon(new object[] { 1, "1" }), Is.EqualTo(0));
        Assert.That(Kata.DivCon(new object[] { -1, "1" }), Is.EqualTo(-2));
        Assert.That(Kata.DivCon(new object[] { 1, "-1" }), Is.EqualTo(2));
        Assert.That(Kata.DivCon(new object[] { 1 }), Is.EqualTo(1));
        Assert.That(Kata.DivCon(new object[] { "1" }), Is.EqualTo(-1));
        Assert.That(Kata.DivCon(new object[] { }), Is.EqualTo(0));
    }
}
