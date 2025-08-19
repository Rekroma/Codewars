using System.Linq;
using System.Collections.Generic;

namespace Kyu7.MaxPossibleScore;

public class Kata
{
    public static int MaxPossibleScore(Dictionary<object, int> obj, object[] arr)
    {
        int maxScore = 0;

        foreach (KeyValuePair<object, int> kvp in obj)
        {
            if (arr.Contains(kvp.Key))
            {
                maxScore += kvp.Value * 2;
            }
            else
            {
                maxScore += kvp.Value;
            }
        }

        return maxScore;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void FixedTests()
    {
        TestIt(new Dictionary<object, int> { { "a", 1 } }, new object[] { }, 1);
        TestIt(new Dictionary<object, int> { { "a", 1 } }, new object[] { "a" }, 2);
        TestIt(new Dictionary<object, int> { { "a", 1 }, { "b", 14 } }, new object[] { "b" }, 29);
        TestIt(new Dictionary<object, int> { { "a", 1 }, { "b", 2 }, { "c", 4 } }, new object[] { "a", "b", "c" }, 14);
        TestIt(new Dictionary<object, int> { { "a", 2 }, { "b", 5 }, { "c", 8 } }, new object[] { "c" }, 23);
    }

    private void TestIt(Dictionary<object, int> inputDict, object[] inputArray, int expected)
    {
        Assert.That(Kata.MaxPossibleScore(inputDict, inputArray), Is.EqualTo(expected),
          $"maxPossibleScore({{{string.Join(", ", inputDict.Select(kvp => $"'{kvp.Key}': {kvp.Value}"))}}}, {{{string.Join(", ", inputArray)}}}) should return {expected}");
    }
}