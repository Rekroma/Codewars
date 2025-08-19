namespace Kyu6.TortoiseRacing;

public class Tortoise
{
    public static int[] Race(int v1, int v2, int g)
    {
        if (v1 >= v2) return null;

        int totalSeconds = (g * 3600) / (v2 - v1);
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        return new int[] { hours, minutes, seconds };
    }
}


[TestFixture]
public class TortoiseTests
{

    [Test]
    public void Test1()
    {
        Assert.That(Tortoise.Race(720, 850, 70), Is.EqualTo(new int[] { 0, 32, 18 }));
        Assert.That(Tortoise.Race(80, 91, 37), Is.EqualTo(new int[] { 3, 21, 49 }));
        Assert.That(Tortoise.Race(80, 100, 40), Is.EqualTo(new int[] { 2, 0, 0 }));
    }
}