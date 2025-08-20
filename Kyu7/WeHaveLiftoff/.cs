using System.Collections.Generic;
using System.Linq;

namespace Kyu7.WeHaveLiftoff;

public static class Kata
{
    public static string Liftoff(List<int> instructions)
    {
        return string.Join(" ", instructions.OrderByDescending(x => x)) + " liftoff!";
    }
}


[TestFixture]
public class SampleTest
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(new List<int> { 2, 8, 10, 9, 1, 3, 4, 7, 6, 5 }).Returns("10 9 8 7 6 5 4 3 2 1 liftoff!");
        }
    }

    [Test, TestCaseSource("testCases")]
    public string Test(List<int> instructions) =>
        Kata.Liftoff(instructions);
}
