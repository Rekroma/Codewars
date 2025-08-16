namespace Kyu8.CatYearsDogYears;

public class Dinglemouse
{
    public static int[] humanYearsCatYearsDogYears(int humanYears)
    {
        return new int[] { humanYears, 15 + (humanYears >= 2 ? 9 + 4 * (humanYears - 2) : 0), 15 + (humanYears >= 2 ? 9 + 5 * (humanYears - 2) : 0) };
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void One()
    {
        Assert.That(Dinglemouse.humanYearsCatYearsDogYears(1), Is.EqualTo(new int[] { 1, 15, 15 }));
    }

    [Test, Order(2)]
    public void Two()
    {
        Assert.That(Dinglemouse.humanYearsCatYearsDogYears(2), Is.EqualTo(new int[] { 2, 24, 24 }));
    }

    [Test, Order(3)]
    public void Ten()
    {
        Assert.That(Dinglemouse.humanYearsCatYearsDogYears(10), Is.EqualTo(new int[] { 10, 56, 64 }));
    }

}