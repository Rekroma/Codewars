using System.Linq;

namespace Kyu8.IfYouCantSleepJustCountSheep;

public static class Kata
{
    public static string CountSheep(int n)
    {
        return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Example Tests")]
    public void ExampleTests()
    {
        Assert.That(Kata.CountSheep(0), Is.EqualTo(""));
        Assert.That(Kata.CountSheep(1), Is.EqualTo("1 sheep..."));
        Assert.That(Kata.CountSheep(2), Is.EqualTo("1 sheep...2 sheep..."));
        Assert.That(Kata.CountSheep(3), Is.EqualTo("1 sheep...2 sheep...3 sheep..."));
    }
}