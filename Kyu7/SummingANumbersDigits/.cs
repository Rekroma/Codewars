using System;

namespace Kyu7.SummingANumbersDigit;

public class Kata
{
    public static int SumDigits(int number)
    {
        int sum = 0;

        foreach (char digit in Math.Abs(number).ToString())
        {
            sum += digit - '0';
        }

        return sum;
    }
}


[TestFixture]
public class Fixed_Tests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(10).Returns(1);
            yield return new TestCaseData(99).Returns(18);
            yield return new TestCaseData(-32).Returns(5);
        }
    }

    [Test, TestCaseSource("testCases")]
    public int FixedTest(int number) => Kata.SumDigits(number);
}
