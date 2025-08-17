namespace Kyu8.RemoveExclamationMarks;

public class Kata
{
    public static string RemoveExclamationMarks(string s)
    {
        return s.Replace("!", "");
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public static void MyTests()
    {
        Assert.That(Kata.RemoveExclamationMarks(""), Is.EqualTo(""), "Input: Empty string");
        Assert.That(Kata.RemoveExclamationMarks("!"), Is.EqualTo(""), "Input: " + "!");
        Assert.That(Kata.RemoveExclamationMarks("!!"), Is.EqualTo(""), "Input: " + "!!");
        Assert.That(Kata.RemoveExclamationMarks("Hi!"), Is.EqualTo("Hi"), "Input: " + "Hi!");
        Assert.That(Kata.RemoveExclamationMarks("!?!"), Is.EqualTo("?"), "Input: " + "!?!");
    }
}