namespace Kyu8.SentenceSmash;

public class Kata
{
    public static string Smash(string[] words)
    {
        return string.Join(" ", words);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Smash(new string[] { "hello" }), Is.EqualTo("hello"));
        Assert.That(Kata.Smash(new string[] { "hello", "world" }), Is.EqualTo("hello world"));
        Assert.That(Kata.Smash(new string[] { "hello", "amazing", "world" }), Is.EqualTo("hello amazing world"));
        Assert.That(Kata.Smash(new string[] { "this", "is", "a", "really", "long", "sentence" }), Is.EqualTo("this is a really long sentence"));
        Assert.That(Kata.Smash(new string[] { "" }), Is.EqualTo(""));
    }
}