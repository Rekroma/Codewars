using System.Linq;

namespace Kyu7.IsNDivisibleBy;

public static class KataChallenge
{
    public static bool IsDivisible(params int[] list)
    {
        return list.Select((x, i) => list[0] % list[i] == 0).All(x => x == true);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void BasicTest1()
    {
        Assert.That(KataChallenge.IsDivisible(3, 3, 4), Is.EqualTo(false));
    }

    [Test, Order(2)]
    public void BasicTest2()
    {
        Assert.That(KataChallenge.IsDivisible(12, 3, 4), Is.EqualTo(true));
    }
}