using System.Linq;

namespace Kyu7.ExesAndOhs;

public static class Kata
{
    public static bool XO(string input)
    {
        return input.ToLower().Count(x => x == 'o') == input.ToLower().Count(x => x == 'x');
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    [Order(1)]
    public void ExampleTests()
    {
        Assert.That(Kata.XO("xo"), Is.EqualTo(true));
        Assert.That(Kata.XO("xxOo"), Is.EqualTo(true));
        Assert.That(Kata.XO("xxxm"), Is.EqualTo(false));
        Assert.That(Kata.XO("Oo"), Is.EqualTo(false));
        Assert.That(Kata.XO("ooom"), Is.EqualTo(false));
    }
}