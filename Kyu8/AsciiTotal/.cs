using System.Linq;

namespace AsciiTotal;

public class Kata
{
    public static int UniTotal(string str)
    {
        return str.Sum(x => (int)x);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("An empty string should return zero")]
    [Order(1)]
    public void ZeroTest()
    {
        Assert.That(Kata.UniTotal(""), Is.EqualTo(0));
    }

    [Test, Description("Should work with single letters")]
    [Order(2)]
    public void SingleTest()
    {
        Assert.That(Kata.UniTotal("a"), Is.EqualTo(97));
        Assert.That(Kata.UniTotal("b"), Is.EqualTo(98));
        Assert.That(Kata.UniTotal("c"), Is.EqualTo(99));
        Assert.That(Kata.UniTotal("d"), Is.EqualTo(100));
        Assert.That(Kata.UniTotal("e"), Is.EqualTo(101));
    }

    [Test, Description("Should work with multiple letters")]
    [Order(3)]
    public void MultipleTest()
    {
        Assert.That(Kata.UniTotal("aaa"), Is.EqualTo(291));
    }

    [Test, Description("Should work with sentence and spaces")]
    [Order(4)]
    public void SentenceTest()
    {
        Assert.That(Kata.UniTotal("Mary Had A Little Lamb"), Is.EqualTo(1873));
    }
}