using System.Linq;

namespace Kyu8.CountByX;

public static class Kata
{
    public static int[] CountBy(int x, int n)
    {
        return Enumerable.Range(1, n).Select(i => i * x).ToArray();
    }
}


[TestFixture]
public static class Test
{
    [Test, Order(1)]
    public static void CountBy1()
    {
        Assert.That(Kata.CountBy(1, 5), Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }), "Array does not match");
    }

    [Test, Order(2)]
    public static void CountBy2()
    {
        Assert.That(Kata.CountBy(2, 5), Is.EqualTo(new int[] { 2, 4, 6, 8, 10 }), "Array does not match");
    }
}
