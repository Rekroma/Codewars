using static Game.Logic;

namespace Kyu8.GrasshopperTerminalGameFunction;

public class Kata
{
    public static void DoTurn()
    {
        RollDice();
        Move();
        Combat();
        GetCoins();
        BuyHealth();
        PrintStatus();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("One Turn")]
    public void Test()
    {
        Kata.DoTurn();

        Assert.That(Log.Count, Is.EqualTo(6), "should call all 6 functions");
        Assert.That(Log[0], Is.EqualTo("RollDice"), "should roll dice first");
        Assert.That(Log[1], Is.EqualTo("Move"), "should move second");
        Assert.That(Log[2], Is.EqualTo("Combat"), "should combat third");
        Assert.That(Log[3], Is.EqualTo("GetCoins"), "should get coins fourth");
        Assert.That(Log[4], Is.EqualTo("BuyHealth"), "should buy health fifth");
        Assert.That(Log[5], Is.EqualTo("PrintStatus"), "should print status sixth");
    }
}