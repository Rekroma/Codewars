using System;
using System.Linq;
using System.Numerics;

namespace Kyu6.DoesMyumberLookBigInThis;
public class Kata
{
    public static bool Narcissistic(int value)
    {
        int[] digits = value.ToString().Select(c => c - '0').ToArray();
        BigInteger sum = digits.Select(i => (int)Math.Pow(i, digits.Length)).Sum();

        return value == sum;
    }
}


[TestFixture]
public class Sample_Test
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(1)
                            .Returns(true)
                            .SetDescription("1 is narcissitic");
            yield return new TestCaseData(371)
                            .Returns(true)
                            .SetDescription("371 is narcissitic");

        }
    }

    [Test, TestCaseSource("testCases")]
    public bool Test(int n) => Kata.Narcissistic(n);
}