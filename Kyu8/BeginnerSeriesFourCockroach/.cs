namespace Kyu8.Beginner.SeriesFourCockroach;

public class Cockroach
{
    public static int CockroachSpeed(double x)
    {
        return (int)(x * 27.778);
    }
}


[TestFixture]
public class CockTest1
{
    [Test]
    public void Test1()
    {
        Assert.That(Cockroach.CockroachSpeed(1.08), Is.EqualTo(30));
        Assert.That(Cockroach.CockroachSpeed(1.09), Is.EqualTo(30));
        Assert.That(Cockroach.CockroachSpeed(0), Is.EqualTo(0));
    }
}