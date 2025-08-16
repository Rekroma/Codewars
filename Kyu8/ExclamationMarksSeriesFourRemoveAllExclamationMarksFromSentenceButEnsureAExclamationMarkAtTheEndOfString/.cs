namespace Kyu8.ExclamationMarksSeriesFourRemoveAllExclamationMarksFromSentenceButEnsureAExclamationMarkAtTheEndOfString;

public class Kata
{
    public static string Remove(string s)
    {
        return $"{s.Replace("!", "")}!";
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Remove("Hi!"), Is.EqualTo("Hi!"));
        Assert.That(Kata.Remove("Hi!!!"), Is.EqualTo("Hi!"));
        Assert.That(Kata.Remove("!Hi"), Is.EqualTo("Hi!"));
        Assert.That(Kata.Remove("!Hi!"), Is.EqualTo("Hi!"));
        Assert.That(Kata.Remove("Hi! Hi!"), Is.EqualTo("Hi Hi!"));
        Assert.That(Kata.Remove("Hi"), Is.EqualTo("Hi!"));
    }
}