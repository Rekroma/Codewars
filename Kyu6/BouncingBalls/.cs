namespace Kyu6.BouncingBalls;

public class BouncingBall
{

    public static int bouncingBall(double h, double bounce, double window)
    {

        if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h) return -1;

        int mom = 1;
        double bounceHeight = h * bounce;

        while (bounceHeight > window)
        {
            mom += 2;
            bounceHeight *= bounce;
        }

        return mom;
    }
}


[TestFixture]
public class BouncingBallTests
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(BouncingBall.bouncingBall(3.0, 0.66, 1.5), Is.EqualTo(3));
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(BouncingBall.bouncingBall(30.0, 0.66, 1.5), Is.EqualTo(15));
    }
}