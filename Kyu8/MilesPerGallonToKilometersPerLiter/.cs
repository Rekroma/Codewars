using System;

namespace Kyu8.MilesPerGallonToKilometersPerLiter;

public static class Kata
{
    public static double Converter(int mpg)
    {
        return Math.Round(mpg * 1.609344 / 4.54609188, 2);
    }
}


[TestFixture]
public class ConverterTests
{
    [Test, Order(1)]
    public void Basic_Tests()
    {
        Assert.That(Kata.Converter(12), Is.EqualTo(4.25));
        Assert.That(Kata.Converter(24), Is.EqualTo(8.50));
        Assert.That(Kata.Converter(36), Is.EqualTo(12.74));
    }
}