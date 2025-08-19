using System;

namespace Kyu6.RoundAndRound;

public static class RoundAndRound
{
    public static decimal RoundBy2DecimalPlaces(this decimal number)
    {
        return Math.Round((decimal)number, 2, MidpointRounding.AwayFromZero);
    }
}


[TestFixture]
public class RoundAndRoundTest
{
    [Test]
    public void ExampleTest()
    {
        Assert.That(2m.RoundBy2DecimalPlaces(), Is.EqualTo(2m));
        Assert.That(7.477m.RoundBy2DecimalPlaces(), Is.EqualTo(7.48m));
        Assert.That((-4.999m).RoundBy2DecimalPlaces(), Is.EqualTo(-5m));
        Assert.That(18.123m.RoundBy2DecimalPlaces(), Is.EqualTo(18.12m));
        Assert.That(0m.RoundBy2DecimalPlaces(), Is.EqualTo(0m));
        Assert.That(1.455m.RoundBy2DecimalPlaces(), Is.EqualTo(1.46m));
        Assert.That((-1.455m).RoundBy2DecimalPlaces(), Is.EqualTo(-1.46m));
        Assert.That(1.055m.RoundBy2DecimalPlaces(), Is.EqualTo(1.06m));
        Assert.That((-1.055m).RoundBy2DecimalPlaces(), Is.EqualTo(-1.06m));
        Assert.That(16.765m.RoundBy2DecimalPlaces(), Is.EqualTo(16.77m));
        Assert.That((-16.765m).RoundBy2DecimalPlaces(), Is.EqualTo(-16.77m));
        Assert.That(1.025m.RoundBy2DecimalPlaces(), Is.EqualTo(1.03m));
        Assert.That((-1.025m).RoundBy2DecimalPlaces(), Is.EqualTo(-1.03m));
        Assert.That(16.355m.RoundBy2DecimalPlaces(), Is.EqualTo(16.36m));
        Assert.That((-16.345m).RoundBy2DecimalPlaces(), Is.EqualTo(-16.35m));
        Assert.That((-1.1949999999999999999999999999m).RoundBy2DecimalPlaces(), Is.EqualTo(-1.19m));
        Assert.That((-1.1950000000000000000000000001m).RoundBy2DecimalPlaces(), Is.EqualTo(-1.20m));
        Assert.That(1.1949999999999999999999999999m.RoundBy2DecimalPlaces(), Is.EqualTo(1.19m));
        Assert.That(1.1950000000000000000000000001m.RoundBy2DecimalPlaces(), Is.EqualTo(1.20m));
        Assert.That((-1.1849999999999999999999999999m).RoundBy2DecimalPlaces(), Is.EqualTo(-1.18m));
        Assert.That((-1.1850000000000000000000000001m).RoundBy2DecimalPlaces(), Is.EqualTo(-1.19m));
        Assert.That(1.1849999999999999999999999999m.RoundBy2DecimalPlaces(), Is.EqualTo(1.18m));
        Assert.That(1.1850000000000000000000000001m.RoundBy2DecimalPlaces(), Is.EqualTo(1.19m));
    }
}