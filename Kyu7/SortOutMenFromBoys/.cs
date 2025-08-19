using System;
using System.Linq;

namespace Kyu7.SortOutTheMenFromBoys;

public class Kata
{
    public static int[] MenFromBoys(int[] values)
    {
        var distinctValues = values.Distinct();
        var evens = distinctValues.Where(x => x % 2 == 0).OrderBy(x => x);
        var odds = distinctValues.Where(x => x % 2 != 0).OrderByDescending(x => x);

        return evens.Concat(odds).ToArray();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.MenFromBoys(new int[] { 7, 3, 14, 17 }), Is.EqualTo(new int[] { 14, 17, 7, 3 }));
        Assert.That(Kata.MenFromBoys(new int[] { 2, 43, 95, 90, 37 }), Is.EqualTo(new int[] { 2, 90, 95, 43, 37 }));
        Assert.That(Kata.MenFromBoys(new int[] { 20, 33, 50, 34, 43, 46 }), Is.EqualTo(new int[] { 20, 34, 46, 50, 43, 33 }));
        Assert.That(Kata.MenFromBoys(new int[] { 82, 91, 72, 76, 76, 100, 85 }), Is.EqualTo(new int[] { 72, 76, 82, 100, 91, 85 }));
        Assert.That(Kata.MenFromBoys(new int[] { 2, 15, 17, 15, 2, 10, 10, 17, 1, 1 }), Is.EqualTo(new int[] { 2, 10, 17, 15, 1 }));
        Assert.That(Kata.MenFromBoys(new int[] { -32, -39, -35, -41 }), Is.EqualTo(new int[] { -32, -35, -39, -41 }));
        Assert.That(Kata.MenFromBoys(new int[] { -64, -71, -63, -66, -65 }), Is.EqualTo(new int[] { -66, -64, -63, -65, -71 }));
        Assert.That(Kata.MenFromBoys(new int[] { -94, -99, -100, -99, -96, -99 }), Is.EqualTo(new int[] { -100, -96, -94, -99 }));
        Assert.That(Kata.MenFromBoys(new int[] { -53, -26, -53, -27, -49, -51, -14 }), Is.EqualTo(new int[] { -26, -14, -27, -49, -51, -53 }));
        Assert.That(Kata.MenFromBoys(new int[] { -17, -45, -15, -33, -85, -56, -86, -30 }), Is.EqualTo(new int[] { -86, -56, -30, -15, -17, -33, -45, -85 }));
        Assert.That(Kata.MenFromBoys(new int[] { 12, 89, -38, -78 }), Is.EqualTo(new int[] { -78, -38, 12, 89 }));
        Assert.That(Kata.MenFromBoys(new int[] { 2, -43, 95, -90, 37 }), Is.EqualTo(new int[] { -90, 2, 95, 37, -43 }));
        Assert.That(Kata.MenFromBoys(new int[] { 82, -61, -87, -12, 21, 1 }), Is.EqualTo(new int[] { -12, 82, 21, 1, -61, -87 }));
        Assert.That(Kata.MenFromBoys(new int[] { 63, -57, 76, -85, 88, 2, -28 }), Is.EqualTo(new int[] { -28, 2, 76, 88, 63, -57, -85 }));
        Assert.That(Kata.MenFromBoys(new int[] { 49, 818, -282, 900, 928, 281, -282, -1 }), Is.EqualTo(new int[] { -282, 818, 900, 928, 281, 49, -1 }));
    }
}