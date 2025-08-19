using System;
using System.Linq;

namespace Kyu6.PlentyOfFishInThePond;

public class Game
{
    public int fish(string shoal)
    {
        int[] shoalSorted = shoal.Select(c => (int)char.GetNumericValue(c)).OrderBy(x => x).ToArray();
        int size = 1;
        int xp = 0;

        foreach (int fish in shoalSorted)
        {
            if (fish > size) break;

            xp += fish;

            while (xp >= size * 4)
            {
                xp -= size * 4;
                size++;
            }
        }

        return size;
    }
}


[TestFixture]
class KataTestClass
{
    [TestCase, Order(1)]
    public void BasicTest1()
    {
        Game game = new Game();
        string shoal = "";
        Assert.That(game.fish(shoal), Is.EqualTo(1));
    }

    [TestCase, Order(2)]
    public void BasicTest2()
    {
        Game game = new Game();
        string shoal = "0";
        Assert.That(game.fish(shoal), Is.EqualTo(1));
    }

    [TestCase, Order(3)]
    public void BasicTest3()
    {
        Game game = new Game();
        string shoal = "6";
        Assert.That(game.fish(shoal), Is.EqualTo(1));
    }

    [TestCase, Order(4)]
    public void BasicTest4()
    {
        Game game = new Game();
        string shoal = "1111";
        Assert.That(game.fish(shoal), Is.EqualTo(2));
    }

    [TestCase, Order(5)]
    public void BasicTest5()
    {
        Game game = new Game();
        string shoal = "11112222";
        Assert.That(game.fish(shoal), Is.EqualTo(3));
    }

    [TestCase, Order(6)]
    public void BasicTest6()
    {
        Game game = new Game();
        string shoal = "111122223333";
        Assert.That(game.fish(shoal), Is.EqualTo(4));
    }

    [TestCase, Order(7)]
    public void BasicTest7()
    {
        Game game = new Game();
        string shoal = "111111111111";
        Assert.That(game.fish(shoal), Is.EqualTo(3));
    }

    [TestCase, Order(8)]
    public void ExtraTest8()
    {
        Game game = new Game();
        string shoal = "111111111111111111112222222222";
        Assert.That(game.fish(shoal), Is.EqualTo(5));
    }

    [TestCase, Order(9)]
    public void BasicTest9()
    {
        Game game = new Game();
        string shoal = "151128241212192113722321331";
        Assert.That(game.fish(shoal), Is.EqualTo(5));
    }
}