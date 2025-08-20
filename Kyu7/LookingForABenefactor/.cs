using System;
using System.Linq;

namespace Kyu7.LookingForABenefactor;

public class NewAverage
{
    public static long NewAvg(double[] arr, double navg)
    {
        double required = navg * (arr.Length + 1) - arr.Sum();

        if (required <= 0) throw new ArgumentException();

        return (long)Math.Ceiling(required);
    }
}


[TestFixture]
public static class NewAverageTests
{
    private static void testing(long actual, long expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(1)]
    public static void BasicTests()
    {
        double[] a = new double[] { 14, 30, 5, 7, 9, 11, 15 };
        testing(NewAverage.NewAvg(a, 100), 709);
        a = new double[] { 14.0, 30.0, 5.0, 7.0, 9.0, 11.0, 16.0 };
        testing(NewAverage.NewAvg(a, 90), 628);
    }

    [Test, Order(2)]
    public static void ErrorTests()
    {
        double[] a = new double[] { 14, 30, 5, 7, 9, 11, 15 };
        Assert.That(() => NewAverage.NewAvg(a, 2), Throws.ArgumentException);
    }
}