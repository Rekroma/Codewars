namespace Kyu8.UefaEuroTwoZeroOneSix;

public class Kata
{
    public static string UefaEuro2016(string[] teams, int[] scores)
    {
        return $"At match {teams[0]} - {teams[1]}, {(scores[0] == scores[1] ? "teams played draw." : $"{(scores[0] > scores[1] ? teams[0] : teams[1])} won!")}";
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.UefaEuro2016(new[] { "Germany", "Ukraine" }, new[] { 2, 0 }), Is.EqualTo("At match Germany - Ukraine, Germany won!"));
        Assert.That(Kata.UefaEuro2016(new[] { "Belgium", "Italy" }, new[] { 0, 2 }), Is.EqualTo("At match Belgium - Italy, Italy won!"));
        Assert.That(Kata.UefaEuro2016(new[] { "Portugal", "Iceland" }, new[] { 1, 1 }), Is.EqualTo("At match Portugal - Iceland, teams played draw."));
    }
}