using System;

namespace Kyu8.NoZerosForHeros;

public class NoBoring
{
    public static int NoBoringZeros(int n)
    {
        return (n == 0) ? 0 : Convert.ToInt32(n.ToString().TrimEnd('0'));
    }
}


[TestFixture]
public static class NoZerosForHeroesTests
{
    private static void doTest(int n, int expected)
    {
        Assert.That(NoBoring.NoBoringZeros(n), Is.EqualTo(expected), $"Failed for n = {n}");
    }

    [Test, Order(1), Description("Sample Tests")]
    public static void TestSampleCases()
    {
        doTest(1450, 145);
        doTest(960000, 96);
        doTest(1050, 105);
        doTest(-1050, -105);
        doTest(-105, -105);
        doTest(0, 0);
        doTest(2016, 2016);
    }
}