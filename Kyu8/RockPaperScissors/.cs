namespace Kyu8.RockPaperScissors;

public class Kata
{
    public string Rps(string p1, string p2)
    {
        if (p1 == "rock" && p2 == "scissors" || p1 == "scissors" && p2 == "paper" || p1 == "paper" && p2 == "rock")
            return "Player 1 won!";

        else if (p1 == "scissors" && p2 == "rock" || p1 == "paper" && p2 == "scissors" || p1 == "rock" && p2 == "paper")
            return "Player 2 won!";

        else return "Draw!";
    }
}


[TestFixture]
public class KataTests
{
    Kata kata = new Kata();

    [Test]
    [Order(1)]
    public void Player1Win()
    {
        Assert.That(kata.Rps("rock", "scissors"), Is.EqualTo("Player 1 won!"));
        Assert.That(kata.Rps("scissors", "paper"), Is.EqualTo("Player 1 won!"));
        Assert.That(kata.Rps("paper", "rock"), Is.EqualTo("Player 1 won!"));
    }

    [Test]
    [Order(2)]
    public void Player2Win()
    {
        Assert.That(kata.Rps("scissors", "rock"), Is.EqualTo("Player 2 won!"));
        Assert.That(kata.Rps("paper", "scissors"), Is.EqualTo("Player 2 won!"));
        Assert.That(kata.Rps("rock", "paper"), Is.EqualTo("Player 2 won!"));
    }

    [Test]
    [Order(3)]
    public void Draw()
    {
        Assert.That(kata.Rps("rock", "rock"), Is.EqualTo("Draw!"));
        Assert.That(kata.Rps("scissors", "scissors"), Is.EqualTo("Draw!"));
        Assert.That(kata.Rps("paper", "paper"), Is.EqualTo("Draw!"));
    }
}