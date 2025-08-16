namespace Kyu8.SimpleFunTwoSixOneWhoseMove;

public class Kata
{
    public static string WhoseMove(string lastPlayer, bool win)
    {
        return win ? lastPlayer : lastPlayer == "black" ? "white" : "black";
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void FixedTests()
    {
        Assert.That(Kata.WhoseMove("black", false), Is.EqualTo("white"));
        Assert.That(Kata.WhoseMove("white", true), Is.EqualTo("white"));
        Assert.That(Kata.WhoseMove("white", false), Is.EqualTo("black"));
    }
}