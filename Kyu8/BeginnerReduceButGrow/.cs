using System.Linq;

namespace BeginnerReduceButGrow;

public class Kata
{
    public static int Grow(int[] x)
    {
        return x.Aggregate((a, b) => a * b);
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    [Order(1)]
    public void BasicTests()
    {
        Assert.That(Kata.Grow(new[] { 1, 2, 3 }), Is.EqualTo(6));
        Assert.That(Kata.Grow(new[] { 4, 1, 1, 1, 4 }), Is.EqualTo(16));
        Assert.That(Kata.Grow(new[] { 2, 2, 2, 2, 2, 2 }), Is.EqualTo(64));
    }
}