using System.Linq;

namespace Kyu7.OddOrEven;

public class Kata
{
    public static string OddOrEven(int[] array)
    {
        return array.Sum() % 2 == 0 ? "even" : "odd";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Edge tests")]
    public void EdgeTests()
    {
        var actual = Kata.OddOrEven(new int[] { 0 });
        Assert.That(actual, Is.EqualTo("even"));
        actual = Kata.OddOrEven(new int[] { 1 });
        Assert.That(actual, Is.EqualTo("odd"));
        actual = Kata.OddOrEven(new int[] { });
        Assert.That(actual, Is.EqualTo("even"));
    }

    [Test, Description("Even tests")]
    public void EvenTests()
    {
        var actual = Kata.OddOrEven(new int[] { 0, 1, 5 });
        Assert.That(actual, Is.EqualTo("even"));
        actual = Kata.OddOrEven(new int[] { 0, 1, 3 });
        Assert.That(actual, Is.EqualTo("even"));
        actual = Kata.OddOrEven(new int[] { 1023, 1, 2 });
        Assert.That(actual, Is.EqualTo("even"));
    }

    [Test, Description("Negative Even tests")]
    public void NegativeEvenTests()
    {
        var actual = Kata.OddOrEven(new int[] { 0, -1, -5 });
        Assert.That(actual, Is.EqualTo("even"));
        actual = Kata.OddOrEven(new int[] { 0, -1, -3 });
        Assert.That(actual, Is.EqualTo("even"));
        actual = Kata.OddOrEven(new int[] { -1023, 1, -2 });
        Assert.That(actual, Is.EqualTo("even"));
    }

    [Test, Description("Odd tests")]
    public void OddTests()
    {
        var actual = Kata.OddOrEven(new int[] { 0, 1, 2 });
        Assert.That(actual, Is.EqualTo("odd"));
        actual = Kata.OddOrEven(new int[] { 0, 1, 4 });
        Assert.That(actual, Is.EqualTo("odd"));
        actual = Kata.OddOrEven(new int[] { 1023, 1, 3 });
        Assert.That(actual, Is.EqualTo("odd"));
    }

    [Test, Description("Negative Odd tests")]
    public void NegativeOddTests()
    {
        var actual = Kata.OddOrEven(new int[] { 0, -1, 2 });
        Assert.That(actual, Is.EqualTo("odd"));
        actual = Kata.OddOrEven(new int[] { 0, 1, -4 });
        Assert.That(actual, Is.EqualTo("odd"));
        actual = Kata.OddOrEven(new int[] { -1023, -1, 3 });
        Assert.That(actual, Is.EqualTo("odd"));
    }
}