namespace Kyu8.WillYouMakeIt;

public static class Kata
{
    public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
    {
        return distanceToPump <= mpg * fuelLeft;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    [Order(1)]
    public void SampleTest()
    {
        Assert.That(Kata.ZeroFuel(50, 25, 2), Is.True);
        Assert.That(Kata.ZeroFuel(100, 50, 1), Is.False);
    }
}