namespace Kyu8.HeadsAndLegs;

public class Kata
{
    public static object Animals(int heads, int legs)
    {
        if (heads == 0 && legs == 0)
        {
            return new int[] { 0, 0 };
        }
        if (heads < 0 || legs < 0 || legs % 2 != 0 || legs > 4 * heads)
        {
            return "No solutions";
        }
        int cows = (legs / 2) - heads;
        int chickens = heads - cows;

        if (chickens < 0 || cows < 0)
        {
            return "No solutions";
        }

        return new int[] { chickens, cows };
    }
}


[TestFixture]
public class KataTests
{
    [Test, Order(1)]
    public void ValidNumberTests()
    {
        Assert.That(Kata.Animals(72, 200), Is.EqualTo(new int[] { 44, 28 }));
        Assert.That(Kata.Animals(116, 282), Is.EqualTo(new int[] { 91, 25 }));
        Assert.That(Kata.Animals(12, 24), Is.EqualTo(new int[] { 12, 0 }));
        Assert.That(Kata.Animals(6, 24), Is.EqualTo(new int[] { 0, 6 }));
        Assert.That(Kata.Animals(344, 872), Is.EqualTo(new int[] { 252, 92 }));
        Assert.That(Kata.Animals(158, 616), Is.EqualTo(new int[] { 8, 150 }));
    }

    [Test, Order(2)]
    public void InvalidNumberTests()
    {
        Assert.That(Kata.Animals(25, 255), Is.EqualTo("No solutions"));
        Assert.That(Kata.Animals(12, 25), Is.EqualTo("No solutions"));
        Assert.That(Kata.Animals(54, 956), Is.EqualTo("No solutions"));
        Assert.That(Kata.Animals(5455, 54956), Is.EqualTo("No solutions"));
    }

    [Test, Order(3)]
    public void EdgeCasesTests()
    {
        Assert.That(Kata.Animals(0, 0), Is.EqualTo(new int[] { 0, 0 }));
        Assert.That(Kata.Animals(-1, -1), Is.EqualTo("No solutions"));
        Assert.That(Kata.Animals(-45, 5), Is.EqualTo("No solutions"));
        Assert.That(Kata.Animals(500, 0), Is.EqualTo("No solutions"));
        Assert.That(Kata.Animals(0, 500), Is.EqualTo("No solutions"));
        Assert.That(Kata.Animals(5, -55), Is.EqualTo("No solutions"));
    }
}