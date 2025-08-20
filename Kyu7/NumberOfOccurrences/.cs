using System;
using System.Linq;

namespace Kyu7.NumberOfOccurrences;

public class OccurrencesKata
{
    public static int NumberOfOccurrences(int x, int[] xs)
    {
        return xs.Where(i => i == x).Count();
    }
}


[TestFixture]
public class OccurrencesKataTests
{
    [Test, Order(1)]
    public void Should_Work_On_Empty_List()
    {
        Assert.That(OccurrencesKata.NumberOfOccurrences(2, new int[0]), Is.EqualTo(0));
    }

    [Test, Order(2)]
    public void Should_Work_On_Examples()
    {
        var example = new int[] { 4, 0, 4 };

        Assert.That(OccurrencesKata.NumberOfOccurrences(4, example), Is.EqualTo(2));

        Assert.That(OccurrencesKata.NumberOfOccurrences(1, example), Is.EqualTo(0));

        Assert.That(OccurrencesKata.NumberOfOccurrences(0, example), Is.EqualTo(1));
    }
}