using System.Linq;

namespace Kyu8.MyHeadIsAtTheWrongEnd;

public class Kata
{
    public static string[] FixTheMeerkat(string[] arr)
    {
        return arr.Reverse().ToArray();
    }
}


[TestFixture]
public class SolutionTest
{
    private static Random rnd = new Random();

    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.FixTheMeerkat(new string[] { "tail", "body", "head" }), Is.EqualTo(new string[] { "head", "body", "tail" }));
        Assert.That(Kata.FixTheMeerkat(new string[] { "tails", "body", "heads" }), Is.EqualTo(new string[] { "heads", "body", "tails" }));
        Assert.That(Kata.FixTheMeerkat(new string[] { "bottom", "middle", "top" }), Is.EqualTo(new string[] { "top", "middle", "bottom" }));
        Assert.That(Kata.FixTheMeerkat(new string[] { "lower legs", "torso", "upper legs" }), Is.EqualTo(new string[] { "upper legs", "torso", "lower legs" }));
        Assert.That(Kata.FixTheMeerkat(new string[] { "sky", "rainbow", "ground" }), Is.EqualTo(new string[] { "ground", "rainbow", "sky" }));
    }
}