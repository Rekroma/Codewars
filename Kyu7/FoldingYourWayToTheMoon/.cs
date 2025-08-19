using System;

namespace Kyu7.FoldingYourNameToTheMoon;

public class Kata
{
    public static int? FoldTo(double distance)
    {
        return distance < 0 ? null : distance < 0.0001 ? 0 : (int?)Math.Ceiling(Math.Log(distance / 0.0001, 2));
    }
}


[TestFixture]
public class SolutionTest
{
    private static object[] Basic_Test_Cases = new object[]
    {
      new object[] {384000000, 42},
    };

    [Test, TestCaseSource(typeof(SolutionTest), "Basic_Test_Cases")]
    public void Basic_Test(double distance, int? expected)
    {
        Assert.That(Kata.FoldTo(distance), Is.EqualTo(expected));
    }
}