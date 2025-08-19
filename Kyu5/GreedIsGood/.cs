using System.Linq;

namespace Kyu6.GreedIsGood;

public static class Kata
{
    public static int Score(int[] dice)
    {
        return dice.GroupBy(x => x)
                   .Sum(g => g.Key switch
                   {
                       1 => (g.Count() / 3) * 1000 + (g.Count() % 3) * 100,
                       5 => (g.Count() / 3) * 500 + (g.Count() % 3) * 50,
                       _ => (g.Count() / 3) * g.Key * 100
                   });
    }
}


public static class ScoreChecker
{
    [Test]
    public static void ShouldBeWorthless()
    {
        Assert.That(Kata.Score(new int[] { 2, 3, 4, 6, 2 }), Is.EqualTo(0));
    }

    [Test]
    public static void ShouldValueTriplets()
    {
        Assert.That(Kata.Score(new int[] { 4, 4, 4, 3, 3 }), Is.EqualTo(400));
    }

    [Test]
    public static void ShouldValueMixedSets()
    {
        Assert.That(Kata.Score(new int[] { 2, 4, 4, 5, 4 }), Is.EqualTo(450));
    }
}