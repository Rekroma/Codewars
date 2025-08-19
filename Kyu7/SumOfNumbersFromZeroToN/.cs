using System.Linq;

namespace Kyu7.SumOfNumbersFromZeroToN;

public class SequenceSum
{
    public static string ShowSequence(int n)
    {
        if (n == 0) return "0=0";
        if (n < 0) return n + "<0";
        string sum = "";

        for (int i = 0; i < n; i++)
        {
            sum += i + "+";
        }

        return sum + n + " = " + Enumerable.Range(0, n + 1).Sum();
    }
}


[TestFixture]
public class SequenceSumTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(SequenceSum.ShowSequence(6), Is.EqualTo("0+1+2+3+4+5+6 = 21"));
    }
}
