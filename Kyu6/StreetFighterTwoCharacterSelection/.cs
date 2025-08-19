using System.Collections.Generic;

namespace Kyu6.StreetFighterTwoCharacterSelection;

public class Kata
{
    public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
    {
        int row = position[0], col = position[1];
        List<string> result = new List<string>();

        foreach (var move in moves)
        {
            if (move == "up") row = 0;
            else if (move == "down") row = 1;
            else if (move == "left") col = (col == 0) ? 5 : col - 1;
            else if (move == "right") col = (col == 5) ? 0 : col + 1;

            result.Add(fighters[row][col]);
        }

        return result.ToArray();
    }
}


[TestFixture]
public class FrontTests
{
    private Kata kata = new Kata();
    private string[][] fighters;

    public FrontTests()
    {
        this.fighters = new string[][]
        {
              new string[] { "Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega" },
              new string[] { "Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison" },
        };
    }

    [Test, Order(1)]
    public void _01_ShouldWorkWithFewMoves()
    {
        var moves = new string[] { "up", "left", "right", "left", "left" };
        var expected = new string[] { "Ryu", "Vega", "Ryu", "Vega", "Balrog" };

        Assert.That(kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves), Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public void _02_ShouldWorkWithNoSelectionCursorMoves()
    {
        var moves = new string[] { };
        var expected = new string[] { };

        Assert.That(kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves), Is.EqualTo(expected));
    }

    [Test, Order(3)]
    public void _03_ShouldWorkWhenAlwaysMovingLeft()
    {
        var moves = new string[] { "left", "left", "left", "left", "left", "left", "left", "left" };
        var expected = new string[] { "Vega", "Balrog", "Guile", "Blanka", "E.Honda", "Ryu", "Vega", "Balrog" };

        Assert.That(kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves), Is.EqualTo(expected));
    }

    [Test, Order(4)]
    public void _04_ShouldWorkWhenAlwaysMovingRight()
    {
        var moves = new string[] { "right", "right", "right", "right", "right", "right", "right", "right" };
        var expected = new string[] { "E.Honda", "Blanka", "Guile", "Balrog", "Vega", "Ryu", "E.Honda", "Blanka" };

        Assert.That(kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves), Is.EqualTo(expected));
    }

    [Test, Order(5)]
    public void _05_ShouldUseAll4DirectionsClockwiseTwice()
    {
        var moves = new string[] { "up", "left", "down", "right", "up", "left", "down", "right" };
        var expected = new string[] { "Ryu", "Vega", "M.Bison", "Ken", "Ryu", "Vega", "M.Bison", "Ken" };

        Assert.That(kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves), Is.EqualTo(expected));
    }

    [Test, Order(6)]
    public void _06_ShouldWorkWhenAlwaysMovingDown()
    {
        var moves = new string[] { "down", "down", "down", "down" };
        var expected = new string[] { "Ken", "Ken", "Ken", "Ken" };

        Assert.That(kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves), Is.EqualTo(expected));
    }

    [Test, Order(7)]
    public void _07_ShouldWorkWhenAlwaysMovingUp()
    {
        var moves = new string[] { "up", "up", "up", "up" };
        var expected = new string[] { "Ryu", "Ryu", "Ryu", "Ryu" };

        Assert.That(kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves), Is.EqualTo(expected));
    }
}