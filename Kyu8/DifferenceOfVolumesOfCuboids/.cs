using System;

namespace Kyu8.DifferenceOfVolumesOfCuboids;

public class Kata
{
    public static int FindDifference(int[] a, int[] b)
    {
        return Math.Abs((a[0] * a[1] * a[2]) - (b[0] * b[1] * b[2]));
    }
}


[TestFixture]
public class Sample_Tests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(new[] { new int[] { 3, 2, 5 }, new int[] { 1, 4, 4 } }).Returns(14);
            yield return new TestCaseData(new[] { new int[] { 9, 7, 2 }, new int[] { 5, 2, 2 } }).Returns(106);
            yield return new TestCaseData(new[] { new int[] { 11, 2, 5 }, new int[] { 1, 10, 8 } }).Returns(30);
            yield return new TestCaseData(new[] { new int[] { 4, 4, 7 }, new int[] { 3, 9, 3 } }).Returns(31);
            yield return new TestCaseData(new[] { new int[] { 15, 20, 25 }, new int[] { 10, 30, 25 } }).Returns(0);
        }
    }

    [Test, TestCaseSource("testCases")]
    public int Test(int[] a, int[] b) => Kata.FindDifference(a, b);
}
