using System.Linq;

namespace Kyu8.ExclamationMarksSeriesSixRemoveNExclamationMarksInTheSentenceFromLeftToRight;

public class Kata
{
    public static string Remove(string s, int n)
    {
        return string.Concat(s.Select(c => c == '!' && n-- > 0 ? '\0' : c)).Replace("\0", "");
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("It should work for basic tests")]
    public void SampleTest()
    {
        Assert.That(Kata.Remove("Hi!", 1), Is.EqualTo("Hi"));
        Assert.That(Kata.Remove("Hi!", 100), Is.EqualTo("Hi"));
        Assert.That(Kata.Remove("Hi!!!", 1), Is.EqualTo("Hi!!"));
        Assert.That(Kata.Remove("Hi!!!", 100), Is.EqualTo("Hi"));
        Assert.That(Kata.Remove("!Hi", 1), Is.EqualTo("Hi"));
        Assert.That(Kata.Remove("!Hi!", 1), Is.EqualTo("Hi!"));
        Assert.That(Kata.Remove("!Hi!", 100), Is.EqualTo("Hi"));
        Assert.That(Kata.Remove("!!!Hi !!hi!!! !hi", 1), Is.EqualTo("!!Hi !!hi!!! !hi"));
        Assert.That(Kata.Remove("!!!Hi !!hi!!! !hi", 3), Is.EqualTo("Hi !!hi!!! !hi"));
        Assert.That(Kata.Remove("!!!Hi !!hi!!! !hi", 5), Is.EqualTo("Hi hi!!! !hi"));
        Assert.That(Kata.Remove("!!!Hi !!hi!!! !hi", 100), Is.EqualTo("Hi hi hi"));
    }
}