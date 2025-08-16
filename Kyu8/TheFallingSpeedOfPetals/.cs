namespace Kyu8.TheFallingSpeedOfPetals;

public static class Kata
{
    public static double SakuraFall(double v)
    {
        return v > 0 ? 400 / v : 0;
    }
}


[TestFixture]
public class SampleTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(
            Kata.SakuraFall(5),
            Is.EqualTo(80).Within(1e-6));
    }
}