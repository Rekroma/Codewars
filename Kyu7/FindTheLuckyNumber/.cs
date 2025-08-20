using System.Linq;

namespace Kyu7.FindTheLuckyNumbers;

public class Kata
{
    public static int[] FilterLucky(int[] x)
    {
        return x.Where(n => n.ToString().Contains('7')).ToArray();
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void FixedTests()
    {
        Assert.That(Kata.FilterLucky(new int[] { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }), Is.EqualTo(new int[] { 7, 70, 17 }));
        Assert.That(Kata.FilterLucky(new int[] { }), Is.EqualTo(new int[] { }));
    }
}