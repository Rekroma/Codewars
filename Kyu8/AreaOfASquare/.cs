using System;

namespace Kyu8.AreaOfASquare;

public class Kata
{
    public static double SquareArea(double A)
    {
        return Math.Round((4 * A * A) / (Math.PI * Math.PI), 2);
    }
}


[TestFixture]
public class Sample_Tests
{
    private const double DELTA = 1e-9;

    private static double[][] testCases = new double[][]
    {
      new double[] {2, 1.62},
      new double[] {0, 0},
      new double[] {14.05, 80},
    };

    [Test, TestCaseSource("testCases")]
    public void SampleTest(double A, double expected)
    {
        double actual = Kata.SquareArea(A);
        Assert.That(actual, Is.EqualTo(expected).Within(DELTA), $"Should determine area of a square for a length of line A of {A}");
    }
}