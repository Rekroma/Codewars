using System.Linq;

namespace Kyu7.CountAllTheSheepsOnFarmInTheHeightsOfNewZealand;

public class Kata
{
    public int lostSheep(int[] friday, int[] saturday, int total)
    {
        return total - (friday.Sum() + saturday.Sum());
    }
}


[TestFixture]
class KataTestClass
{
    [TestCase, Order(1)]
    public void BasicTest1()
    {
        Kata kata = new Kata();
        int[] friday = new int[] { 1, 2 };
        int[] saturday = new int[] { 3, 4 };
        Assert.That(kata.lostSheep(friday, saturday, 15), Is.EqualTo(5));
    }

    [TestCase, Order(2)]
    public void BasicTest2()
    {
        Kata kata = new Kata();
        int[] friday = new int[] { 3, 1, 2 };
        int[] saturday = new int[] { 4, 5 };
        Assert.That(kata.lostSheep(friday, saturday, 21), Is.EqualTo(6));
    }

    [TestCase, Order(3)]
    public void BasicTest3()
    {
        Kata kata = new Kata();
        int[] friday = new int[] { 5, 1, 4 };
        int[] saturday = new int[] { 5, 4 };
        Assert.That(kata.lostSheep(friday, saturday, 29), Is.EqualTo(10));
    }
}