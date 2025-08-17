namespace Kyu8.RemoveFirstAndLastCharacterPartTwo;

public static class Kata
{
    public static string Array(string s)
    {
        return s.Split(',').Length < 3 ? null : string.Join(" ", s.Split(',')[1..^1]);
    }
}


public class KataTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Array(""), Is.Null);
        Assert.That(Kata.Array("1"), Is.Null);
        Assert.That(Kata.Array("1, 3"), Is.Null);
        Assert.That(Kata.Array("1,2,3"), Is.EqualTo("2"));
        Assert.That(Kata.Array("1,2,3,4"), Is.EqualTo("2 3"));
    }
}