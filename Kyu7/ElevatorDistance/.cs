using System;

namespace Kyu7.ElevatorDistance;

public static class Kata
{
    public static int ElevatorDistance(int[] array)
    {
        int floors = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            floors += Math.Abs(array[i] - array[i + 1]);
        }

        return floors;
    }
}


[TestFixture]
public class SolutionTest
{
    private static void Act(int[] array, int expected)
    {
        var msg = $"Invalid answer for array: [{string.Join(",", array)}]";
        var actual = Kata.ElevatorDistance(array);
        Assert.That(actual, Is.EqualTo(expected), msg);
    }

    [TestCase(new[] { 5, 2, 8 }, 9)]
    [TestCase(new[] { 1, 2, 3 }, 2)]
    [TestCase(new[] { 7, 1, 7, 1 }, 18)]
    public void FixedTests(int[] array, int expected)
    {
        Act(array, expected);
    }
}