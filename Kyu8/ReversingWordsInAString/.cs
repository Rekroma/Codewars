namespace Kyu8.ReversingWordsInAString;

using System.Linq;

public class Kata
{
    public static string Reverse(string text)
    {
        return string.Join(" ", text.Split(' ').Reverse());
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Reverse("Hello World"), Is.EqualTo("World Hello"));
        Assert.That(Kata.Reverse("Hi There."), Is.EqualTo("There. Hi"));

        Assert.That(Kata.Reverse("I am an expert at this"), Is.EqualTo("this at expert an am I"));
    }
}