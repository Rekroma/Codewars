using System.Linq;

namespace Kyu8.CountTheMonkeys;

public static class MonkeyCounter
{
    public static int[] MonkeyCount(int n)
    {
        return Enumerable.Range(1, n).ToArray();
    }
}


[TestFixture]
public class Tests
{
    [TestCase(5, new int[] { 1, 2, 3, 4, 5 })]
    [TestCase(3, new int[] { 1, 2, 3 })]
    [TestCase(9, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    [TestCase(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    [TestCase(20, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 })]
    public void FixedTest(int count, int[] expected)
    {
        int[] actual = MonkeyCounter.MonkeyCount(count);
        Assert.That(actual, Is.EqualTo(expected), $"Failed for input {count}");
    }
}