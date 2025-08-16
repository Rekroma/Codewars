using System;

namespace Kyu8.DuckDuckGoose;

public class Kata
{
    public static string DuckDuckGoose(Player[] players, int goose)
    {
        return players[(goose - 1) % players.Length].Name;
    }
}

public class Player
{
    public string Name { get; set; }

    public Player(string name)
    {
        this.Name = name;
    }
}


[TestFixture]
public class PlayerTests
{
    [TestCase(1, "a")]
    [TestCase(3, "c")]
    [TestCase(10, "z")]
    [TestCase(20, "z")]
    [TestCase(30, "z")]
    [TestCase(18, "g")]
    [TestCase(28, "g")]
    [TestCase(12, "b")]
    [TestCase(2, "b")]
    [TestCase(7, "f")]
    public void DuckDuckGooseTests(int goose, string expectedName)
    {
        var exampleNames = new string[] { "a", "b", "c", "d", "c", "e", "f", "g", "h", "z" };
        var players = exampleNames.Select(x => new Player(x)).ToArray();
        string userAns = Kata.DuckDuckGoose(players, goose);
        Assert.That(userAns, Is.EqualTo(expectedName));
    }
}