using System.Linq;

namespace Kyu8.GrasshopperSummation;

public static class Kata
{
    public static int summation(int num)
    {
        return Enumerable.Range(1, num).Sum();
    }
}


[TestFixture]
public static class KataTests
{
    [Test, Order(1)]
    public static void BasicTests()
    {
        Assert.That(Kata.summation(1), Is.EqualTo(1));
        Assert.That(Kata.summation(8), Is.EqualTo(36));
        Assert.That(Kata.summation(22), Is.EqualTo(253));
        Assert.That(Kata.summation(100), Is.EqualTo(5050));
        Assert.That(Kata.summation(213), Is.EqualTo(22791));
    }
}