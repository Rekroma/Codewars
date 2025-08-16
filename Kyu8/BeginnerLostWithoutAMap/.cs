using System.Linq;

namespace Kyu8.BeginnerLostWithoutAMap;

public class Kata
{
    public static int[] Maps(int[] x)
    {
        return x.Select(x => x * 2).ToArray();
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Maps(new[] { 1, 2, 3 }), Is.EqualTo(new[] { 2, 4, 6 }));
        Assert.That(Kata.Maps(new[] { 4, 1, 1, 1, 4 }), Is.EqualTo(new[] { 8, 2, 2, 2, 8 }));
        Assert.That(Kata.Maps(new[] { 2, 2, 2, 2, 2, 2 }), Is.EqualTo(new[] { 4, 4, 4, 4, 4, 4 }));
    }
}