using System.Text.RegularExpressions;

namespace Kyu8.ContaminationOneString;

public class Kata
{
    public static string Contamination(string text, string character)
    {
        return Regex.Replace(text, ".", character);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Contamination("abc", "z"), Is.EqualTo("zzz"));
        Assert.That(Kata.Contamination("", "z"), Is.EqualTo(""));
        Assert.That(Kata.Contamination("abc", String.Empty), Is.EqualTo(""));
        Assert.That(Kata.Contamination("_3ebzgh4", "&"), Is.EqualTo("&&&&&&&&"));
        Assert.That(Kata.Contamination("//case", " "), Is.EqualTo("      "));
    }
}