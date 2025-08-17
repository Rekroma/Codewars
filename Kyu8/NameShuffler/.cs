using System.Linq;

namespace Kyu8.NameShuffler;

public class Kata
{
    public static string NameShuffler(string str)
    {
        return string.Join(" ", str.Split(' ').Reverse());
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        Assert.That(Kata.NameShuffler("john McClane"), Is.EqualTo("McClane john"));
        Assert.That(Kata.NameShuffler("Mary jeggins"), Is.EqualTo("jeggins Mary"));
        Assert.That(Kata.NameShuffler("tom jerry"), Is.EqualTo("jerry tom"));
    }
}