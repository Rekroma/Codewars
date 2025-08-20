namespace Kyu6.TakeANumberAndSumItsDigitsRaisedToTheConsecutivePowersAndEureka;

using System.Collections.Generic;

public class SumDigPower
{
    public static long[] SumDigPow(long a, long b)
    {
        List<long> result = new List<long>();

        for (long i = a; i <= b; i++)
        {
            long sum = 0;
            string number = i.ToString();

            for (int j = 0; j < number.Length; j++)
            {
                sum += (long)System.Math.Pow(char.GetNumericValue(number[j]), j + 1);
            }
            if (sum == i)
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }
}


[TestFixture]
public static class SumDigPowerTests
{

    private static string Array2String(long[] list)
    {
        return "[" + string.Join(", ", list) + "]";
    }
    private static void testing(long a, long b, long[] res)
    {
        Assert.That(Array2String(SumDigPower.SumDigPow(a, b)),
                    Is.EqualTo(Array2String(res)));
    }
    [Test]
    public static void test1()
    {
        testing(1, 10, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        testing(1, 100, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 });
        testing(10, 100, new long[] { 89 });
        testing(90, 100, new long[] { });
        testing(90, 150, new long[] { 135 });
        testing(50, 150, new long[] { 89, 135 });
        testing(10, 150, new long[] { 89, 135 });

    }
}