namespace Kyu8.OppositesAttract;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    {
        return flower1 % 2 != flower2 % 2;
    }
}


[TestFixture]
public class LoveTests
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(LoveDetector.lovefunc(1, 4), Is.EqualTo(true));
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(LoveDetector.lovefunc(2, 2), Is.EqualTo(false));
    }

    [Test, Order(3)]
    public void Test3()
    {
        Assert.That(LoveDetector.lovefunc(0, 1), Is.EqualTo(true));
    }

    [Test, Order(4)]
    public void Test4()
    {
        Assert.That(LoveDetector.lovefunc(0, 0), Is.EqualTo(false));
    }
}