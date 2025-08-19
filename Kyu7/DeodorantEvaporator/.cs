namespace Kyu7.DeodorantEvaporator;

public class Evaporator
{

    public static int evaporator(double content, double evap_per_day, double threshold)
    {
        int days = 0;
        double thresholdInMl = content * threshold / 100;

        while (content > thresholdInMl)
        {
            content -= content * evap_per_day / 100;
            days++;
        }

        return days;
    }
}


[TestFixture]
public class EvaporatorTests
{

    [Test]
    public void Test1()
    {
        Assert.That(Evaporator.evaporator(10, 10, 10), Is.EqualTo(22));
    }
}