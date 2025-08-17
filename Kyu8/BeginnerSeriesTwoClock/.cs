namespace Kyu8.BeginnerSeriesTwoClock;

public static class Clock
{
    public static int Past(int h, int m, int s)
    {
        return h * 3600000 + m * 60000 + s * 1000;
    }
}


[TestFixture]
public class ClockTest
{
    [Test]
    public void Test()
    {
        Assert.That(Clock.Past(0, 1, 1), Is.EqualTo(61000));
    }
}