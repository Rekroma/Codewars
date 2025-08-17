using System.Linq;

namespace Kyu8.Plural;

public class Kata
{
    public static bool Plural(double n)
    {
        return n != 1;
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Plural(0), Is.EqualTo(true), "Plural for 0");
        Assert.That(Kata.Plural(0.5), Is.EqualTo(true), "Plural for 0.5");
        Assert.That(Kata.Plural(1), Is.EqualTo(false), "Plural for 1");
        Assert.That(Kata.Plural(100), Is.EqualTo(true), "Plural for 100");
        Assert.That(Kata.Plural(double.PositiveInfinity), Is.EqualTo(true), "Plural for Infinity");
    }
}