using System.Linq;
using System.Collections.Generic;

namespace Kyu8.FindMultiplesOfANumber;

public class Kata
{
    public static List<int> FindMultiples(int integer, int limit)
    {
        return Enumerable.Range(1, limit / integer).Select(x => x * integer).ToList();
    }
}


[TestFixture]
public class Tests
{
    [Test, Order(1)]
    public void SampleTests()
    {
        DoTest(5, 25, new List<int> { 5, 10, 15, 20, 25 });
        DoTest(1, 2, new List<int> { 1, 2 });
        DoTest(5, 7, new List<int> { 5 });
        DoTest(4, 27, new List<int> { 4, 8, 12, 16, 20, 24 });
        DoTest(11, 54, new List<int> { 11, 22, 33, 44 });
    }

    private static void DoTest(int n, int limit, List<int> expected)
    {
        String message = String.Format("for n = {0} and limit = {1}\n", n, limit);
        List<int> actual = Kata.FindMultiples(n, limit);
        Assert.That(actual, Is.EqualTo(expected), message);
    }
}