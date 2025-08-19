using System.Linq;

namespace Kyu7.Incrementer;

public static class Kata
{
    public static int[] Incrementer(int[] numbers)
    {
        return numbers = numbers.Select((x, i) => (x + i + 1) % 10).ToArray();
    }
}


[TestFixture]
public class FixedTestSuite
{
    [TestCase(new int[0], new int[0])]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 })]
    [TestCase(new int[] { 4, 6, 7, 1, 3 }, new int[] { 5, 8, 0, 5, 8 })]
    [TestCase(new int[] { 3, 6, 9, 8, 9 }, new int[] { 4, 8, 2, 2, 4 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 8 }, new int[] { 2, 4, 6, 8, 0, 2, 4, 6, 8, 9, 0, 1, 2, 2 })]
    public void SampleTests(int[] numbers, int[] expected)
    {
        Tester.Act(numbers, expected);
    }
}

static class Tester
{
    internal static void Act(int[] numbers, int[] expected)
    {
        var actual = Kata.Incrementer(numbers.ToList().ToArray());
        var msg = $"Invalid answer for numbers: {ArrayToString(numbers)}\n\texpected: {ArrayToString(expected)}\n\tactual: {ArrayToString(actual)}";
        Assert.That(actual, Is.EqualTo(expected), msg);
    }

    internal static string ArrayToString(int[] array)
    {
        return $"[{string.Join(",", array)}]";
    }
}