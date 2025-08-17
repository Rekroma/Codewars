using System.Linq;

namespace Kyu8.SumWithoutHighestAndLowestNumber;

public static class Kata
{
    public static int Sum(int[] numbers)
    {
        return numbers == null || numbers.Length <= 1 ? 0 : numbers.Sum() - numbers.Max() - numbers.Min();
    }
}


[TestFixture]
public class SumTests
{
    [Test]
    public void SumPositives()
    {
        Assert.That(Kata.Sum(new[] { 6, 2, 1, 8, 10 }), Is.EqualTo(16));
    }
}