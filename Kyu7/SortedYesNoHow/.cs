using System.Linq;

namespace Kyu7.SortedYesNoHow;

public class Kata
{
    public static string IsSortedAndHow(int[] array)
    {
        return array.SequenceEqual(array.OrderBy(x => x))
            ? "yes, ascending"
            : array.SequenceEqual(array.OrderByDescending(x => x))
                ? "yes, descending"
                : "no";
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.IsSortedAndHow(new[] { 1, 2 }), Is.EqualTo("yes, ascending"));
        Assert.That(Kata.IsSortedAndHow(new[] { 15, 7, 3, -8 }), Is.EqualTo("yes, descending"));
        Assert.That(Kata.IsSortedAndHow(new[] { 4, 2, 30 }), Is.EqualTo("no"));
    }
}