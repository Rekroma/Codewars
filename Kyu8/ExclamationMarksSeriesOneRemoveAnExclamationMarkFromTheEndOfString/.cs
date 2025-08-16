namespace Kyu8.ExclamationMarksSeriesOneRemoveAnExclamationMarkFromTheEndOfString;

public class Kata
{
    public static string Remove(string s)
    {
        return s.Length > 0 && s[s.Length - 1] == '!' ? s.Remove(s.Length - 1) : s;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("It should work for basic tests")]
    public void SampleTest()
    {
        Assert.That(Kata.Remove("Hi!"), Is.EqualTo("Hi"));
        Assert.That(Kata.Remove("Hi!!!"), Is.EqualTo("Hi!!"));
        Assert.That(Kata.Remove("!Hi"), Is.EqualTo("!Hi"));
        Assert.That(Kata.Remove("!Hi!"), Is.EqualTo("!Hi"));
        Assert.That(Kata.Remove("Hi! Hi"), Is.EqualTo("Hi! Hi"));
        Assert.That(Kata.Remove("Hi"), Is.EqualTo("Hi"));
    }
}