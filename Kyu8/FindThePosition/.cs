namespace Kyu8.FindThePosition;

public class Kata
{
    public static string Position(char alphabet)
    {
        return $"Position of alphabet: {"abcdefghijklmnopqrstuvwxyz".IndexOf(alphabet) + 1}";
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Position('a'), Is.EqualTo("Position of alphabet: 1"));
        Assert.That(Kata.Position('z'), Is.EqualTo("Position of alphabet: 26"));
        Assert.That(Kata.Position('e'), Is.EqualTo("Position of alphabet: 5"));
    }
}