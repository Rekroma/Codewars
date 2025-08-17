using System;

namespace Kyu8.TipCalculator;

public class Kata
{
    public static int CalculateTip(double amount, string rating) =>
     rating.ToLower() switch
     {
         "terrible" => 0,
         "poor" => (int)Math.Ceiling(0.05 * amount),
         "good" => (int)Math.Ceiling(0.10 * amount),
         "great" => (int)Math.Ceiling(0.15 * amount),
         "excellent" => (int)Math.Ceiling(0.20 * amount),
         _ => -1,
     };
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        Assert.That(Kata.CalculateTip(20, "Excellent"), Is.EqualTo(4));
        Assert.That(Kata.CalculateTip(26.95, "good"), Is.EqualTo(3));
    }
}