using System;
using System.Linq;

namespace Kyu7.SimpleRemoveDuplicates;

public class Solution
{
    public static int[] solve(int[] arr)
    {
        return arr.Reverse().Distinct().Reverse().ToArray();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(Solution.solve(new int[] { 3, 4, 4, 3, 6, 3 }), Is.EqualTo(new int[] { 4, 6, 3 }));
        Assert.That(Solution.solve(new int[] { 1, 2, 1, 2, 1, 2, 3 }), Is.EqualTo(new int[] { 1, 2, 3 }));
        Assert.That(Solution.solve(new int[] { 1, 2, 3, 4 }), Is.EqualTo(new int[] { 1, 2, 3, 4 }));
        Assert.That(Solution.solve(new int[] { 1, 1, 4, 5, 1, 2, 1 }), Is.EqualTo(new int[] { 4, 5, 2, 1 }));
    }
}