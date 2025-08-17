namespace Kyu8.GrasshopperMessiGoals;

public static class Kata
{
    public static int la_liga_goals = 43;
    public static int champions_league_goals = 10;
    public static int copa_del_rey_goals = 5;
    public static int total_goals = la_liga_goals + champions_league_goals + copa_del_rey_goals;
}


[TestFixture]
public static class KataTests
{

    [Test]
    public static void Tests()
    {
        Assert.That(Kata.total_goals, Is.EqualTo(58));
    }
}