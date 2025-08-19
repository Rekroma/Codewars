namespace Kyu7.BattleOfTheCharactersEasy;

public class Kata
{
    public static string Battle(string x, string y)
    {
        string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int scoreX = 0;
        int scoreY = 0;

        foreach (char letter in x)
        {
            scoreX += abc.IndexOf(letter) + 1;
        }
        foreach (char letter in y)
        {
            scoreY += abc.IndexOf(letter) + 1;
        }

        return scoreX == scoreY ? "Tie!" : scoreX > scoreY ? x : y;
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Battle("AAA", "Z"), Is.EqualTo("Z"));
        Assert.That(Kata.Battle("ONE", "TWO"), Is.EqualTo("TWO"));
        Assert.That(Kata.Battle("ONE", "NEO"), Is.EqualTo("Tie!"));
        Assert.That(Kata.Battle("FOUR", "FIVE"), Is.EqualTo("FOUR"));
    }
}