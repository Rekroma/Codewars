namespace Kyu8.GrasshopperMessiGoalsFunction;

public class Kata
{
    public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals)
    {
        return laLigaGoals + copaDelReyGoals + championsLeagueGoals;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    [Order(1)]
    public void NoGoals()
    {
        Assert.That(Kata.GetGoals(0, 0, 0), Is.EqualTo(0));
    }
    [Test]
    [Order(2)]
    public void FiftyEightGoals()
    {
        Assert.That(Kata.GetGoals(43, 10, 5), Is.EqualTo(58));
    }
}