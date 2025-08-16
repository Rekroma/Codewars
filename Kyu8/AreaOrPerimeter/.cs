namespace Kyu8.AreaOrPerimeter;

public class MathCheck
{
    public static int AreaOrPerimeter(int l, int w)
    {
        return l == w ? l * w : 2 * l + 2 * w;
    }
}


[TestFixture]
public class Test
{
    [Test, Order(1)]
    public void FixedTest()
    {
        Assert.That(MathCheck.AreaOrPerimeter(4, 4), Is.EqualTo(16));
        Assert.That(MathCheck.AreaOrPerimeter(6, 10), Is.EqualTo(32));
    }
}