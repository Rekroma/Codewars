using System.Linq;
using System.Collections.Generic;

namespace Kyu8.ReverseListOrder;

public class Kata
{
    public static List<int> ReverseList(List<int> list)
    {
        return Enumerable.Reverse(list).ToList();
    }
}


[TestFixture]
public class SolutionTest
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(new List<int> { 1, 2, 3, 4 }).Returns(new List<int> { 4, 3, 2, 1 });
            yield return new TestCaseData(new List<int> { 3, 1, 5, 4 }).Returns(new List<int> { 4, 5, 1, 3 });
            yield return new TestCaseData(new List<int> { 3, 6, 9, 2 }).Returns(new List<int> { 2, 9, 6, 3 });
        }
    }

    [Test, TestCaseSource("testCases")]
    public List<int> SampleTest(List<int> list) => Kata.ReverseList(list);
}
