using System;
using System.Linq;

namespace Kyu7.SmallestValueOfAnArray;

public class Kata
{
    public static int FindSmallest(int[] numbers, string mode)
    {
        return mode == "value" ? numbers.Min() : Array.IndexOf(numbers, numbers.Min());
    }
}


public class Tests
{
    private static void DoTest(int[] numbers, String mode, int expected)
    {
        String message = String.Format("for mode = \"{0}\" and array = [{1}]\n",
            mode, String.Join(", ", numbers)
        );
        int actual = Kata.FindSmallest(numbers, mode);
        Assert.That(actual, Is.EqualTo(expected), message);
    }

    [Test]
    public void SampleTests()
    {
        DoTest(new int[] { 1, 2, 3, 4, 5 }, "value", 1);
        DoTest(new int[] { 1, 2, 3, 4, 5 }, "index", 0);
        DoTest(new int[] { 5, 4, 3, 2, 1 }, "value", 1);
        DoTest(new int[] { 5, 4, 3, 2, 1 }, "index", 4);
        DoTest(new int[] { Int32.MaxValue }, "value", Int32.MaxValue);
        DoTest(new int[] { 0, Int32.MinValue }, "value", Int32.MinValue);
    }
}