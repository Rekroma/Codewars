using System;
using System.Linq;

namespace Kyu7.FindTheMiddleElement;

public class Kata
{
    public static int Gimme(double[] inputArray)
    {
        return Array.IndexOf(inputArray, inputArray.OrderBy(x => x).ElementAt(1));
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void SampleTests()
    {
        Assert.That(Kata.Gimme(new double[] { 2, 3, 1 }), Is.EqualTo(0));
        Assert.That(Kata.Gimme(new double[] { 5, 10, 14 }), Is.EqualTo(1));
    }
}