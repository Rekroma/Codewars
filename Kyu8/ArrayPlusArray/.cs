using System.Linq;

namespace Kyu8.ArrayPlusArray;

public static class Kata
{
    public static int ArrayPlusArray(int[] arr1, int[] arr2)
    {
        return arr1.Sum() + arr2.Sum();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }), Is.EqualTo(21));
        Assert.That(Kata.ArrayPlusArray(new int[] { -1, -2, -3 }, new int[] { -4, -5, -6 }), Is.EqualTo(-21));
        Assert.That(Kata.ArrayPlusArray(new int[] { 0, 0, 0 }, new int[] { 4, 5, 6 }), Is.EqualTo(15));
        Assert.That(Kata.ArrayPlusArray(new int[] { 100, 200, 300 }, new int[] { 400, 500, 600 }), Is.EqualTo(2100));

    }
}