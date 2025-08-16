using System.Text.RegularExpressions;

namespace Kyu8.ExclamationMarksSeriesOneOneReplaceAllVowelToExclamationMarkInTheSentence;

public static class Kata
{
    public static string Replace(string s)
    {
        return Regex.Replace(s, "[aeiouAEIOU]", "!");
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Basic Tests")]
    public void BasicTest()
    {
        Assert.That(Kata.Replace("Hi!"), Is.EqualTo("H!!"));
        Assert.That(Kata.Replace("!Hi! Hi!"), Is.EqualTo("!H!! H!!"));
        Assert.That(Kata.Replace("aeiou"), Is.EqualTo("!!!!!"));
        Assert.That(Kata.Replace("ABCDE"), Is.EqualTo("!BCD!"));
    }
}