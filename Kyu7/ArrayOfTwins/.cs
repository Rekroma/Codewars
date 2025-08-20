using System;
using System.Linq;

namespace Kyu7.ArrayOfTwins;

public static class Kata
{
    public static bool Twins(int[] arr)
    {
        foreach (var v in arr)
        {
            if (arr.Count(x => x == v) != 2) return false;
        }

        return true;
    }
}


[TestFixture]
public class SampleTest
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(new[] { new int[] { 1, 2, 3, 1, 2, 3 } }).Returns(true);
            yield return new TestCaseData(new[] { new int[] { 33, 5, 17, 5 } }).Returns(false);
            yield return new TestCaseData(new[] { new int[] { 2, 16, 2, 17, 2, 16 } }).Returns(false);
        }
    }

    [Test, TestCaseSource("testCases")]
    public bool Test(int[] arr) =>
      Kata.Twins(arr);
}