using System.Linq;

namespace Kyu8.FindMaximumAndMinimumValuesOfAList;

public class Kata
{
    public int Min(int[] list)
    {
        return list.Min();
    }

    public int Max(int[] list)
    {
        return list.Max();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void TestExamples()
    {
        Assert.That(new Kata().Min(new[] { -52, 56, 30, 29, -54, 0, -110 }), Is.EqualTo(-110));
        Assert.That(new Kata().Min(new[] { 42, 54, 65, 87, 0 }), Is.EqualTo(0));
        Assert.That(new Kata().Max(new[] { 4, 6, 2, 1, 9, 63, -134, 566 }), Is.EqualTo(566));
        Assert.That(new Kata().Max(new[] { 5 }), Is.EqualTo(5));
    }
}