using System.Globalization;

namespace Kyu7.ARuleOfDivisibilityBySeven;

public class DivSeven
{
    public static long[] Seven(long m)
    {
        int count = 0;

        do
        {
            m = int.Parse(m.ToString().Substring(0, m.ToString().Length - 2)) - (m % 10);
            count++;
        }
        while (m >= 100 && m % 7 != 0);

        return new long[] { m, count };

    }
}


[TestFixture]
public class DivSevenTests
{

    [Test]
    public void BasicTests()
    {
        Assert.That(DivSeven.Seven(1021), Is.EqualTo(new long[] { 10, 2 }));
        Assert.That(DivSeven.Seven(1603), Is.EqualTo(new long[] { 7, 2 }));
        Assert.That(DivSeven.Seven(371), Is.EqualTo(new long[] { 35, 1 }));
        Assert.That(DivSeven.Seven(483), Is.EqualTo(new long[] { 42, 1 }));
    }
}