using System.Linq;

namespace Kyu8.ReturnTwoHighestValuesInList;

public static class Kata
{
    public static int[] TwoHighest(int[] arr)
    {
        return arr.OrderByDescending(x => x).Distinct().Take(2).ToArray();
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.TwoHighest(Array.Empty<int>()), Is.EqualTo(Array.Empty<int>()));
        Assert.That(Kata.TwoHighest(new[] { 15 }), Is.EqualTo(new[] { 15 }));
        Assert.That(Kata.TwoHighest(new[] { 15, 20, 20, 17 }), Is.EqualTo(new[] { 20, 17 }));
        Assert.That(Kata.TwoHighest(new[] { 4, 10, 10, 9 }), Is.EqualTo(new[] { 10, 9 }));
        Assert.That(Kata.TwoHighest(new[] { 1, 1, 1 }), Is.EqualTo(new[] { 1 }));
        Assert.That(Kata.TwoHighest(new[] { 4, 1, 2, 3, 5 }), Is.EqualTo(new[] { 5, 4 }));
        Assert.That(Kata.TwoHighest(new[] { 1, 1, 2, 2, 3, 3 }), Is.EqualTo(new[] { 3, 2 }));
        Assert.That(Kata.TwoHighest(new[] { 0, 3, 0, 6, 0, 9 }), Is.EqualTo(new[] { 9, 6 }));
        Assert.That(Kata.TwoHighest(new[] { 0, 0, 0 }), Is.EqualTo(new[] { 0 }));
        Assert.That(Kata.TwoHighest(new[] { 0, 9, 0 }), Is.EqualTo(new[] { 9, 0 }));
    }
}