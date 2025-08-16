namespace Kyu8.DoYouSpeakEnglish;

static class Kata
{
    public static bool SpeakEnglish(string sentence)
    {
        return sentence.ToLower().Contains("english");
    }
}


[TestFixture]
public class SolutionTest
{
    [TestCase("hello world", false)]
    [TestCase("egnlish", false)]
    [TestCase("", false)]
    [TestCase("english", true)]
    [TestCase("1234english ;k", true)]
    [TestCase("I speak English", true)]
    [TestCase("ABC123DOREME", false)]
    [TestCase("eNgliSh", true)]
    [TestCase("1234#$%%eNglish ;k9", true)]
    [TestCase("spanish, english, french", true)]
    [TestCase("englishENGLISHEnGlISHENglisH", true)]
    [TestCase("HeLlO tHeR3 enGLiSh MuffIN", true)]
    public void SampleTests(string str, bool expected)
    {
        var actual = Kata.SpeakEnglish(str);
        Assert.That(actual, Is.EqualTo(expected), $"Input: \"{str}\"");
    }
}