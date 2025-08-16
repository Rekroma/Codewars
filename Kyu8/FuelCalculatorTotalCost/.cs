using System;

namespace Kyu8.FuelCalculatorTotalCost;

public class Kata
{
    public static double FuelPrice(double litres, double pricePerLitre)
    {
        double discount = 0;
        if (litres >= 2) discount = Math.Min(0.25, Math.Floor(litres / 2) * 0.05);
        return Math.Round(litres * pricePerLitre - (litres * discount), 2);
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.FuelPrice(5, 1.23), Is.EqualTo(5.65));
        Assert.That(Kata.FuelPrice(8, 2.5), Is.EqualTo(18.40));
        Assert.That(Kata.FuelPrice(5, 5.6), Is.EqualTo(27.50));
    }
}