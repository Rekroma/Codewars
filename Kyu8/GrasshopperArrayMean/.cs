using System.Linq;

namespace Kyu8.GrasshopperArrayMean;

public class GrassHopper
{
    public static int FindAverage(int[] nums)
    {
        return (int)nums.Average();
    }
}


[TestFixture]
public class MyTest
{
    [Test, Order(1)]
    public void FirstTest()
    {
        Assert.That(GrassHopper.FindAverage(new[] { 1 }), Is.EqualTo(1));
    }

    [Test, Order(2)]
    public void SecondTest()
    {
        Assert.That(GrassHopper.FindAverage(new[] { 1, 3, 5, 7 }), Is.EqualTo(4));
    }

    [Test, Order(3)]
    public void ThirdTest()
    {
        Assert.That(GrassHopper.FindAverage(new[] { -10, -5, -5, 0 }), Is.EqualTo(-5));
    }

    [Test, Order(4)]
    public void FourthTest()
    {
        Assert.That(GrassHopper.FindAverage(new[] { 0 }), Is.EqualTo(0));
    }
}
