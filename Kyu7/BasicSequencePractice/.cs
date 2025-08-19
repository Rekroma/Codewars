using System;

namespace Kyu7.BasicSequencePractice;

public class SequenceSum
{
    public static int[] SumOfN(int n)
    {
        int[] result = new int[Math.Abs(n) + 1];
        int sum = 0;

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = sum;
            sum += (n >= 0) ? i + 1 : -(i + 1);
        }

        return result;
    }
}


[TestFixture]
public class SequenceSumTests
{
    [Test, Order(1)]
    public void Test_3()
    {
        int input = 3;
        int[] expected = new int[] { 0, 1, 3, 6 };

        int[] actual = SequenceSum.SumOfN(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public void Test_Neg4()
    {
        int input = -4;
        int[] expected = new int[] { 0, -1, -3, -6, -10 };

        int[] actual = SequenceSum.SumOfN(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(3)]
    public void Test_1()
    {
        int input = 1;
        int[] expected = new int[] { 0, 1 };

        int[] actual = SequenceSum.SumOfN(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(4)]
    public void Test_0()
    {
        int input = 0;
        int[] expected = new int[] { 0 };

        int[] actual = SequenceSum.SumOfN(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}