using System;

namespace Kyu8.GeometryBasicsCircleAreaInTwoD;

public static class Kata
{
    public static double CircleArea(Circle circle)
    {
        return Math.PI * Math.Pow(circle.Radius, 2);
    }
}


[TestFixture]
public class SolutionTest
{
    private static double epsilon = 1e-6;

    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.CircleArea(new Circle(new Point(10, 10), 30)), Is.EqualTo(2827.433388).Within(epsilon));
        Assert.That(Kata.CircleArea(new Circle(new Point(25, -70), 30)), Is.EqualTo(2827.433388).Within(epsilon));
        Assert.That(Kata.CircleArea(new Circle(new Point(-15, 5), 0)), Is.EqualTo(0).Within(epsilon));
        Assert.That(Kata.CircleArea(new Circle(new Point(-15, 5), 12.5)), Is.EqualTo(490.873852).Within(epsilon));
    }
}