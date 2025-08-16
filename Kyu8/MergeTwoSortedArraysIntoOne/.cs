using System.Linq;

namespace Kyu8.MergeTwoSortedArraysIntoOne;

public class Kata
{
    public static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        return arr1.Concat(arr2).Distinct().OrderBy(x => x).ToArray();
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.MergeArrays(new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }), Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }));

        Assert.That(Kata.MergeArrays(new[] { 1, 3, 5, 7, 9 }, new[] { 10, 8, 6, 4, 2 }), Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

        Assert.That(Kata.MergeArrays(new[] { 1, 3, 5, 7, 9, 11, 12 }, new[] { 1, 2, 3, 4, 5, 10, 12 }), Is.EqualTo(new[] { 1, 2, 3, 4, 5, 7, 9, 10, 11, 12 }));

        Assert.That(Kata.MergeArrays(new int[] { }, new int[] { }), Is.EqualTo(new int[] { }));

        Assert.That(Kata.MergeArrays(new[] { 1, 2, 3 }, new int[] { }), Is.EqualTo(new[] { 1, 2, 3 }));

        Assert.That(Kata.MergeArrays(new int[] { }, new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }));

        Assert.That(Kata.MergeArrays(new[] { -3, -2, -1, 0 }, new int[] { 1, 2, 3, 4 }), Is.EqualTo(new int[] { -3, -2, -1, 0, 1, 2, 3, 4 }));
    }
}