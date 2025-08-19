using System.Linq;

namespace Kyu7.ProductOfMaximumsOfArrayArraySeriesTwo;

public class Kata
{
    public static int MaxProduct(int[] arr, int size)
    {
        return arr.OrderByDescending(x => x).Take(size).Aggregate((a, b) => a * b);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        Assert.That(Kata.MaxProduct(new int[] { 4, 3, 5 }, 2), Is.EqualTo(20));
        Assert.That(Kata.MaxProduct(new int[] { 10, 8, 7, 9 }, 3), Is.EqualTo(720));
        Assert.That(Kata.MaxProduct(new int[] { 8, 6, 4, 6 }, 3), Is.EqualTo(288));
        Assert.That(Kata.MaxProduct(new int[] { 10, 2, 3, 8, 1, 10, 4 }, 5), Is.EqualTo(9600));
        Assert.That(Kata.MaxProduct(new int[] { 13, 12, -27, -302, 25, 37, 133, 155, -14 }, 5), Is.EqualTo(247895375));
        Assert.That(Kata.MaxProduct(new int[] { -4, -27, -15, -6, -1 }, 2), Is.EqualTo(4));
        Assert.That(Kata.MaxProduct(new int[] { -17, -8, -102, -309 }, 2), Is.EqualTo(136));
        Assert.That(Kata.MaxProduct(new int[] { 10, 3, -27, -1 }, 3), Is.EqualTo(-30));
        Assert.That(Kata.MaxProduct(new int[] { 14, 29, -28, 39, -16, -48 }, 4), Is.EqualTo(-253344));
        Assert.That(Kata.MaxProduct(new int[] { 1 }, 1), Is.EqualTo(1));
    }
}