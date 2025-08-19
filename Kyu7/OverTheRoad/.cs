namespace Kyu7.OverTheRoad;

public class CodeWars
{
    public static long OverTheRoad(long address, long n)
    {
        return (n * 2 + 1) - address;
    }
}


[TestFixture]
public class Basic_Tests
{
    [Test]
    public void basic_test_cases()
    {
        Assert.That(CodeWars.OverTheRoad(1, 3), Is.EqualTo(6));
        Assert.That(CodeWars.OverTheRoad(3, 3), Is.EqualTo(4));
        Assert.That(CodeWars.OverTheRoad(2, 3), Is.EqualTo(5));
        Assert.That(CodeWars.OverTheRoad(3, 5), Is.EqualTo(8));
        Assert.That(CodeWars.OverTheRoad(7, 11), Is.EqualTo(16));
    }
}