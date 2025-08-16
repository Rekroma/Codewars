namespace Kyu8.ExclamationMarksSeriesTwoRemoveAllExclamationMarksFromTheEndOfSentence;

public class Kata
{
    public static string Remove(string s)
    {
        return s.TrimEnd('!');
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("It should work for basic tests")]
    public void SampleTest()
    {
        Assert.That(Kata.Remove("Hi!"), Is.EqualTo("Hi"));
        Assert.That(Kata.Remove("Hi!!!"), Is.EqualTo("Hi"));
        Assert.That(Kata.Remove("!Hi"), Is.EqualTo("!Hi"));
        Assert.That(Kata.Remove("!Hi!"), Is.EqualTo("!Hi"));
        Assert.That(Kata.Remove("Hi! Hi"), Is.EqualTo("Hi! Hi"));
        Assert.That(Kata.Remove("Hi"), Is.EqualTo("Hi"));
    }
}