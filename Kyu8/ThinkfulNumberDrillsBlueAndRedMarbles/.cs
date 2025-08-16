namespace Kyu8.ThinkfulNumberDrillsBlueAndRedMarbles;

public static class BlueAndRedMarbles
{
    public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
    {
        return (double)(blueStart - bluePulled) / ((blueStart - bluePulled) + (redStart - redPulled));
    }
}


[TestFixture]
public class SolutionTest
{
    private const double Delta = 0.0000001;

    [Test]
    public void MyTest()
    {
        Assert.That(BlueAndRedMarbles.GuessBlue(5, 5, 2, 3), Is.EqualTo(0.6).Within(Delta));
        Assert.That(BlueAndRedMarbles.GuessBlue(5, 7, 4, 3), Is.EqualTo(0.2).Within(Delta));
        Assert.That(BlueAndRedMarbles.GuessBlue(12, 18, 4, 6), Is.EqualTo(0.4).Within(Delta));
    }
}