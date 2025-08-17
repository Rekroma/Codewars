namespace Kyu8.OnlineRpgPlayersToQualifyingStage;

public class Kata
{
    public static object PlayerRankUp(int points)
    {
        return points >= 100 ? "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up." : false;
    }
}


[TestFixture]
public class PlayerRankUp
{
    [Test, Order(1)]
    public static void Test64()
    {
        Assert.That(Kata.PlayerRankUp(64), Is.EqualTo(false));
    }

    [Test, Order(2)]
    public static void Test101()
    {
        var expected = "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.";
        Assert.That(Kata.PlayerRankUp(101), Is.EqualTo(expected));
    }
}