using System;

namespace Kyu8.GrasshopperBugSquashing;

public static partial class Kata
{
    public static int Health = 100;
    public static int Position = 0;
    public static int Coins = 0;

    public static void PlayTurn()
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
public class KataTests
{
    [Test, Description("Kata should define variables and store values"), Order(1)]
    public void VariableTest()
    {
        Assert.That(Kata.Health, Is.EqualTo(100));
        Assert.That(Kata.Position, Is.EqualTo(0));
        Assert.That(Kata.Coins, Is.EqualTo(0));
    }

    [Test, Description("PlayTurn should not throw an exception"), Order(2)]
    public void ErrorTest()
    {
        Assert.That(() => Kata.PlayTurn(), Throws.Nothing);
    }

    [Test, Description("should roll dice first"), Order(3)]
    public void OrderTest1()
    {
        Assert.That(Kata.Log[0], Is.EqualTo("RollDice"));
    }

    [Test, Description("should move second"), Order(4)]
    public void OrderTest2()
    {
        Assert.That(Kata.Log[1], Is.EqualTo("Move"));
    }

    [Test, Description("should combat third"), Order(5)]
    public void OrderTest3()
    {
        Assert.That(Kata.Log[2], Is.EqualTo("Combat"));
    }

    [Test, Description("should get coins fourth"), Order(6)]
    public void OrderTest4()
    {
        Assert.That(Kata.Log[3], Is.EqualTo("GetCoins"));
    }

    [Test, Description("should buy health fifth"), Order(7)]
    public void OrderTest5()
    {
        Assert.That(Kata.Log[4], Is.EqualTo("BuyHealth"));
    }

    [Test, Description("should print status sixth"), Order(8)]
    public void OrderTest6()
    {
        Assert.That(Kata.Log[5], Is.EqualTo("PrintStatus"));
    }
}


public static partial class Kata
{
    public static System.Collections.Generic.List<string> Log { get; } = new();

    public static void RollDice() => Log.Add("RollDice");
    public static void Move() => Log.Add("Move");
    public static void Combat() => Log.Add("Combat");
    public static void GetCoins() => Log.Add("GetCoins");
    public static void BuyHealth() => Log.Add("BuyHealth");
    public static void PrintStatus() => Log.Add("PrintStatus");
}