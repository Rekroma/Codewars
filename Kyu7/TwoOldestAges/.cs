using System.Linq;

namespace Kyu7.TwoOldestAges;

public class LargestTwo
{
    public static int[] TwoOldestAges(int[] ages)
    {
        return new int[] { ages.OrderByDescending(x => x).ToArray()[1], ages.OrderByDescending(x => x).ToArray()[0] };
    }
}


[TestFixture]
public class Tests
{

    [Test, Order(1)]
    public void Test1()
    {
        int[] result = LargestTwo.TwoOldestAges(new[] { 1, 2, 10, 8 });
        Assert.That(result, Is.EqualTo(new int[] { 8, 10 }));
    }

    [Test, Order(2)]
    public void Test2()
    {
        int[] result = LargestTwo.TwoOldestAges(new[] { 1, 5, 87, 45, 8, 8 });
        Assert.That(result, Is.EqualTo(new int[] { 45, 87 }));
    }

    [Test, Order(3)]
    public void Test3()
    {
        int[] result = LargestTwo.TwoOldestAges(new[] { 6, 5, 83, 5, 3, 18 });
        Assert.That(result, Is.EqualTo(new int[] { 18, 83 }));
    }

    [Test, Order(4)]
    public void Test4()
    {
        int[] result = LargestTwo.TwoOldestAges(new[] { 6, 5, 83, 83 });
        Assert.That(result, Is.EqualTo(new int[] { 83, 83 }));
    }
}