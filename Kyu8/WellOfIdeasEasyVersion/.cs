using System.Linq;

namespace Kyu8.WellOfIdeasEasyVersion;

public class Kata
{
    public static string Well(string[] x)
    {
        return x.Count(x => x == "good") > 2 ? "I smell a series!" : x.Count(x => x == "good") >= 1 ? "Publish!" : "Fail!";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Well(new string[] { "bad", "bad", "bad" }), Is.EqualTo("Fail!"));
        Assert.That(Kata.Well(new string[] { "good", "bad", "bad", "bad", "bad" }), Is.EqualTo("Publish!"));
        Assert.That(Kata.Well(new string[] { "good", "bad", "bad", "bad", "bad", "good", "bad", "bad", "good" }), Is.EqualTo("I smell a series!"));
    }
}