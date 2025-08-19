namespace Kyu7.SumOfTheFirstNthTermOfSeries;

public class NthSeries
{
    public static string seriesSum(int n)
    {
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += (1.0 / (1 + 3 * i));
        }

        return sum.ToString("0.00");
    }
}


[TestFixture]
public class NthSeriesTests
{

    [Test]
    [Order(1)]
    public void Test1()
    {
        Assert.That(NthSeries.seriesSum(0), Is.EqualTo("0.00"));
    }
    [Test]
    [Order(2)]
    public void Test2()
    {
        Assert.That(NthSeries.seriesSum(9), Is.EqualTo("1.77"));
    }

}
