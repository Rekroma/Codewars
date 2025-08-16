namespace Kyu8.CapitalizationAndMutability;

public class Kata
{
    public static string CapitalizeWord(string word)
    {
        return char.ToUpper(word[0]) + word.Substring(1);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Kata.CapitalizeWord("word"), Is.EqualTo("Word"));
        Assert.That(Kata.CapitalizeWord("i"), Is.EqualTo("I"));
        Assert.That(Kata.CapitalizeWord("glasswear"), Is.EqualTo("Glasswear"));
    }
}