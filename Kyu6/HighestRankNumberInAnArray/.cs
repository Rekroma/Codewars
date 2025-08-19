using System.Linq;

namespace Kyu6.HighestRankNumberInAnArray;

public class Kata
{
    public static int HighestRank(int[] arr)
    {
        return arr.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenByDescending(x => x.Key).SelectMany(x => x).ToArray()[0];
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTest()
    {
        var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
        Assert.That(Kata.HighestRank(arr), Is.EqualTo(12));
    }
}