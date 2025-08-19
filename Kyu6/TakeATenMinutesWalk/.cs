using System.Linq;

namespace Kyu6.TakeATenMinutesWalk;

public class Kata
{
    public static bool IsValidWalk(string[] walk)
    {
        return walk.Length == 10 && walk.Count(x => x == "n") == walk.Count(x => x == "s") && walk.Count(x => x == "e") == walk.Count(x => x == "w");
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    [Order(1)]
    public void SampleTests()
    {
        Assert.That(Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), Is.True, "should return true");
        Assert.That(Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), Is.False, "should return false");
        Assert.That(Kata.IsValidWalk(new string[] { "w" }), Is.False, "should return false");
        Assert.That(Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), Is.False, "should return false");
    }
}