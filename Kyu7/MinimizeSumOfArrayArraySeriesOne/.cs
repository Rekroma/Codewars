using System;
using System.Linq;

namespace Kyu7.MinimizeSumOfArrayArraySeriesOne;

class Kata
{
    public static int MinSum(int[] a)
    {
        int sum = 0;
        a = a.OrderByDescending(x => x).ToArray();

        for (int i = 0; i < Math.Floor((double)a.Length / 2); i++)
        {
            sum += a[i] * a[a.Length - 1 - i];
        }

        return sum;
    }
}


[TestFixture]
class Tests
{
    [TestCase(2, 1, 2)]
    [TestCase(22, 5, 4, 2, 3)]
    [TestCase(342, 12, 6, 10, 26, 3, 24)]
    [TestCase(74, 9, 2, 8, 7, 5, 4, 0, 6)]
    public void BasicTests(int expected, params int[] a)
    {
        Assert.That(Kata.MinSum(a), Is.EqualTo(expected));
    }
    [Test]
    public void EmptyInput()
    {
        var a = new int[] { };
        Assert.That(Kata.MinSum(a), Is.EqualTo(0));
    }
}