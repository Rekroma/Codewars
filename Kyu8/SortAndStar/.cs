using System;
using System.Linq;

namespace Kyu8.SortAndStar;

public class Kata
{
    public static string TwoSort(string[] s)
    {
        return string.Join("***", s.OrderBy(a => a, StringComparer.Ordinal).First().ToArray());
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.TwoSort(new[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" }), Is.EqualTo("b***i***t***c***o***i***n"));
        Assert.That(Kata.TwoSort(new[] { "turns", "out", "random", "test", "cases", "are", "easier", "than", "writing", "out", "basic", "ones" }), Is.EqualTo("a***r***e"));
    }
}