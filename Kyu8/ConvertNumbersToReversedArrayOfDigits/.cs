using System;
using System.Linq;

namespace Kyu8.ConvertNumbersToReversedArrayOfDigits;

class Digitizer
{
    public static long[] Digitize(long n)
    {
        return n.ToString().Reverse().Select(t => Convert.ToInt64(t.ToString())).ToArray();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Digitizer.Digitize(35231), Is.EqualTo(new long[] { 1, 3, 2, 5, 3 }));
        Assert.That(Digitizer.Digitize(0), Is.EqualTo(new long[] { 0 }));
    }
}