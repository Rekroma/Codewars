using System.Linq;

namespace Kyu7.TheHighestProfitWins;

public class MinMax
{
    public static int[] minMax(int[] lst)
    {
        return new int[] { lst.Min(), lst.Max() };
    }
}


[TestFixture]
public class MinMaxTests
{

    [Test]
    public static void BasicTest()
    {
        Assert.That(MinMax.minMax(new int[] { 1, 2, 5, -1, 12, 20 }), Is.EqualTo(new int[] { -1, 20 }));
        Assert.That(MinMax.minMax(new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(new int[] { 1, 5 }));
        Assert.That(MinMax.minMax(new int[] { 1, 2, -3, 4, 5 }), Is.EqualTo(new int[] { -3, 5 }));
    }
}
