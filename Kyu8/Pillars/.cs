namespace Kyu8.Pillars;

public static class Kata
{
    public static int Pillars(int numPill, int dist, int width)
    {
        return numPill < 2 ? 0 : (numPill - 2) * width + (numPill - 1) * dist * 100;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void BasicTest1()
    {
        Assert.That(Kata.Pillars(1, 10, 10), Is.EqualTo(0), "Testing for number of pillars: 1, distance: 10 m and width: 10 cm");
    }

    [Test, Order(2)]
    public void BasicTest2()
    {
        Assert.That(Kata.Pillars(2, 20, 25), Is.EqualTo(2000), "Testing for number of pillars: 2, distance: 20 m and width: 25 cm");
    }

    [Test, Order(3)]
    public void BasicTest3()
    {
        Assert.That(Kata.Pillars(11, 15, 30), Is.EqualTo(15270), "Testing for number of pillars: 11, distance: 15 m and width: 30 cm");
    }
}