using System.Collections.Generic;
using System.Linq;

namespace Kyu6.FindTheUniqueNumber;

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        return numbers.GroupBy(x => x).OrderBy(x => x.Count()).First().Key;
    }
}


[TestFixture]
public class SolutionTest
{
    [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
    [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
    [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
    public int BaseTest(IEnumerable<int> numbers)
    {
        return Kata.GetUnique(numbers);
    }
}