using System.Linq;

namespace Kyu8.SumOfDifferencesInArray;

public static class Kata
{
    public static int SumOfDifferences(int[] arr)
    {
        return arr.Any() ? arr.Max() - arr.Min() : 0;
    }
}


public class KataTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.SumOfDifferences(new int[] { }), Is.EqualTo(0));
        Assert.That(Kata.SumOfDifferences(new int[] { 0 }), Is.EqualTo(0));
        Assert.That(Kata.SumOfDifferences(new int[] { 1 }), Is.EqualTo(0));
        Assert.That(Kata.SumOfDifferences(new int[] { -1 }), Is.EqualTo(0));
        Assert.That(Kata.SumOfDifferences(new int[] { -17, 17 }), Is.EqualTo(34));
        Assert.That(Kata.SumOfDifferences(new int[] { 2, 1, 10 }), Is.EqualTo(9));
        Assert.That(Kata.SumOfDifferences(new int[] { -3, -2, -1 }), Is.EqualTo(2));
        Assert.That(Kata.SumOfDifferences(new int[] { 1, 1, 1, 1, 1 }), Is.EqualTo(0));
        Assert.That(Kata.SumOfDifferences(new int[] { 0, 0, 0, 0, 0 }), Is.EqualTo(0));
        Assert.That(Kata.SumOfDifferences(new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(4));
        Assert.That(Kata.SumOfDifferences(new int[] { 0, 29, 24, 17 }), Is.EqualTo(29));
        Assert.That(Kata.SumOfDifferences(new int[] { 25, 24, -25, 2 }), Is.EqualTo(50));
        Assert.That(Kata.SumOfDifferences(new int[] { -26, -4, -8, -8 }), Is.EqualTo(22));
    }
}