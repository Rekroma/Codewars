using System.Linq;

namespace Kyu6.SortTheOdd;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        var sortedOdds = array.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();
        int oddIndex = 0;

        return array.Select(x => x % 2 != 0 ? sortedOdds[oddIndex++] : x).ToArray();
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }), Is.EqualTo(new int[] { 1, 3, 2, 8, 5, 4 }));
        Assert.That(Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }), Is.EqualTo(new int[] { 1, 3, 5, 8, 0 }));
        Assert.That(Kata.SortArray(new int[] { }), Is.EqualTo(new int[] { }));
    }
}