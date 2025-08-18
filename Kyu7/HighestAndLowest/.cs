using System.Linq;

namespace Kyu7.HighestAndLowest;

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        int[] arr = numbers.Split(' ').Select(int.Parse).ToArray();
        return $"{arr.Max()} {arr.Min()}";
    }
}


[TestFixture]
public class ExampleTests
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"), Is.EqualTo("42 -9"));
    }
    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(Kata.HighAndLow("1 2 3"), Is.EqualTo("3 1"));
    }
}