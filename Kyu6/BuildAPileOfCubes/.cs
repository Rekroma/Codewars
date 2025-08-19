namespace Kyu6.BuildAPileOfCubes;

public class ASum
{
    public static long findNb(long m)
    {
        long n = 0, sum = 0;

        while (sum < m)
        {
            n++;
            sum += n * n * n;
        }

        return sum == m ? n : -1;
    }
}


[TestFixture]
public class ASumTests
{

    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(ASum.findNb(4183059834009), Is.EqualTo(2022));
    }
    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(ASum.findNb(24723578342962), Is.EqualTo(-1));
    }
    [Test, Order(3)]
    public void Test3()
    {
        Assert.That(ASum.findNb(135440716410000), Is.EqualTo(4824));
    }
    [Test, Order(4)]
    public void Test4()
    {
        Assert.That(ASum.findNb(40539911473216), Is.EqualTo(3568));

    }
}
