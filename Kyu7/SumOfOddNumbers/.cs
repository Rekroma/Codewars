using System;

namespace Kyu7.SumOfOddNumbers;

public static class Kata
{
    public static long RowSumOddNumbers(long n)
    {
        return (long)Math.Pow(n, 3);
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void test1()
    {
        Assert.That(Kata.RowSumOddNumbers(1), Is.EqualTo(1));
        Assert.That(Kata.RowSumOddNumbers(42), Is.EqualTo(74088));
    }

}
