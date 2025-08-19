using System.Linq;

namespace Kyu7.DescendingOrder;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        return int.Parse(new string(num.ToString().OrderByDescending(x => x).ToArray()));
    }
}


[TestFixture]
public class Tests
{
    [Test, Order(1)]
    public void Test0()
    {
        Assert.That(Kata.DescendingOrder(0), Is.EqualTo(0));
    }
}