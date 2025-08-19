using System;

namespace kyu7.GrowthOfAPopulation;

class Arge
{
    public static int NbYear(int p0, double percent, int aug, int p)
    {
        int year = 0;

        while (p0 < p)
        {
            Convert.ToInt32(p0 += (int)(p0 * (percent * 0.01) + aug));
            year++;
        }

        return year;
    }
}


[TestFixture]
public static class ArgeTests
{

    private static void testing(int actual, int expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public static void test1()
    {
        testing(Arge.NbYear(1500, 5, 100, 5000), 15);
        testing(Arge.NbYear(1500000, 2.5, 10000, 2000000), 10);
        testing(Arge.NbYear(1500000, 0.25, 1000, 2000000), 94);
    }
}