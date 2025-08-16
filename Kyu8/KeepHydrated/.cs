namespace Kyu8.KeepHydrated;

public class Kata
{
    public static int Litres(double time)
    {
        return (int)time / 2;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [Order(1)]
    public static void Test1()
    {
        Assert.That(Kata.Litres(2), Is.EqualTo(1));
    }

    [Test]
    [Order(2)]
    public static void Test2()
    {
        Assert.That(Kata.Litres(1.4), Is.EqualTo(0));
    }

    [Test]
    [Order(3)]
    public static void Test3()
    {
        Assert.That(Kata.Litres(12.3), Is.EqualTo(6));
    }

    [Test]
    [Order(4)]
    public static void Test4()
    {
        Assert.That(Kata.Litres(0.82), Is.EqualTo(0));
    }

    [Test]
    [Order(5)]
    public static void Test5()
    {
        Assert.That(Kata.Litres(11.8), Is.EqualTo(5));
    }

    [Test]
    [Order(6)]
    public static void Test6()
    {
        Assert.That(Kata.Litres(1787), Is.EqualTo(893));
    }
    [Test]
    [Order(7)]
    public static void Test7()
    {
        Assert.That(Kata.Litres(0), Is.EqualTo(0));
    }

}