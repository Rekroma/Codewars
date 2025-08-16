using System;

namespace Kyu8.ConvertToBinary;

public static class Kata
{
    public static int ToBinary(int n)
    {
        return Convert.ToInt32(Convert.ToString(n, 2));
    }
}


[TestFixture]
public class BasicTests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(1).Returns(1)
                                            .SetDescription("Arguments: (n: 1)\n      Expected: 1");
            yield return new TestCaseData(2).Returns(10)
                                            .SetDescription("Arguments: (n: 2)\n      Expected: 10");
            yield return new TestCaseData(3).Returns(11)
                                            .SetDescription("Arguments: (n: 3)\n      Expected: 11");
            yield return new TestCaseData(5).Returns(101)
                                            .SetDescription("Arguments: (n: 5)\n      Expected: 101");
        }
    }

    [Test, TestCaseSource("testCases")]
    public int Test(int n) =>
      Kata.ToBinary(n);
}