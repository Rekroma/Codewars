namespace Kyu7.SumOfAngles;

public class Kata
{
    public static int Angle(int n)
    {
        return (n - 2) * 180;
    }
}


[TestFixture]
public class SampleTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Angle(3), Is.EqualTo(180));
        Assert.That(Kata.Angle(4), Is.EqualTo(360));
    }
}