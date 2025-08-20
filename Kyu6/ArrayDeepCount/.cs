using System;
using System.Linq;

namespace Kyu6.ArrayDeepCount;

public class Kata
{
    public static int DeepCount(object a)
    {
        if (a is Array arr) return arr.Cast<object>().Sum(DeepCount) + arr.Length;

        return 0;
    }
}


[TestFixture]
public class SolutionTest
{
    private static object[] Basic_Test_Cases = new object[]
    {
      new object[]
      {
        new object[] {},
        0
      },
      new object[]
      {
        new object[] {1, 2, 3},
        3
      },
      new object[]
      {
        new object[] {"x", "y", new object[] {"z"}},
        4
      },
      new object[]
      {
        new object[] {1, 2, new object[] {3, 4, new object[] {5}}},
        7
      },
      new object[]
      {
        new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] {}}}}}}}}},
        8
      }
    };

    [Test, TestCaseSource(typeof(SolutionTest), "Basic_Test_Cases")]
    public void Basic_Tests(object test, int expected)
    {
        Assert.That(Kata.DeepCount(test), Is.EqualTo(expected), $"Expected {expected}");
    }
}