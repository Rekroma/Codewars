using System.Linq;
using System.Collections.Generic;

namespace Kyu7.RemoveTheMinimum;

public class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        return numbers.Count == 0 ? new List<int>() : numbers.Where((_, i) => i != numbers.IndexOf(numbers.Min())).ToList();
    }
}


[TestFixture]
public class RemoveSmallestTests
{
    private static void Tester(List<int> argument, List<int> expectedResult)
    {
        Assert.That(Remover.RemoveSmallest(argument), Is.EqualTo(expectedResult));
    }
    [Test]
    public static void BasicTests()
    {
        Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
        Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
        Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
        Tester(new List<int>(), new List<int>());
    }
}