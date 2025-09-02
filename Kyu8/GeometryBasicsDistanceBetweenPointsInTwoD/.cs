using System;

namespace Kyu8.GeometryBasicsDistanceBetweenPointsInTwoD;

public class Kata
{
    public static double DistanceBetweenPoints(Point a, Point b)
    {
        return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
    }
}


[TestFixture]
public class SolutionTest
{

    [Test]
    public void SampleTest()
    {
        DoTest(new Point(3, 3), new Point(3, 3), 0);
        DoTest(new Point(1, 6), new Point(4, 2), 5);
        DoTest(new Point(-10.2, 12.5), new Point(0.3, 14.7), 10.728001);
    }

    private void DoTest(Point a, Point b, double expected)
    {
        double actual = Kata.DistanceBetweenPoints(a, b);
        Assert.That(actual, Is.EqualTo(expected).Within(1e-6), string.Format("Incorrect answer for:\n  a=Point({0}, {1})\n  b=Point({2}, {3})\n", a.X, a.Y, b.X, b.Y));
    }
}



public class Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}