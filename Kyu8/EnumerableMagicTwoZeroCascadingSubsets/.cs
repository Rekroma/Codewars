using System;
using System.Text;
using System.Collections.Generic;

namespace Kyu8.EnumerableMagicTwoZeroCascadingSubsets;

static class Kata
{
    public static IEnumerable<IEnumerable<int>> EachCons(int[] list, int n)
    {
        if (n <= 0 || n > list.Length)
            yield break;
        for (int i = 0; i <= list.Length - n; i++)
        {
            int[] subArray = new int[n];
            Array.Copy(list, i, subArray, 0, n);
            yield return subArray;
        }
    }
}


public class SolutionTest
{
    static int[] Clone(int[] xs) => xs.Select(x => x).ToArray();
    static int[][] Materialise(IEnumerable<IEnumerable<int>> xss) => xss.Select(xs => xs.ToArray()).ToArray();
    static IEnumerable<IEnumerable<int>> Empty() { yield break; }

    private static void Act(int[] list, int n, IEnumerable<IEnumerable<int>> expected)
    {
        var xs = Clone(list);
        var xssExpected = Materialise(expected);
        var xssActual = Materialise(Kata.EachCons(xs, n));
        var msg = new StringBuilder();
        msg.AppendLine($"Invalid answer for list: [{string.Join(",", xs)}] and n: {n}");
        msg.AppendLine($"  Expected: [{string.Join(",", xssExpected.Select(ys => $"[{string.Join(",", ys)}]"))}]");
        msg.AppendLine($"    Actual: [{string.Join(",", xssActual.Select(ys => $"[{string.Join(",", ys)}]"))}]");
        Assert.That(xssActual, Is.EqualTo(xssExpected), msg.ToString());
    }

    [TestFixture]
    public class SampleTests
    {
        [Test(Description = "List: [3, 5, 8, 13] n: 1")]
        [Order(1)]
        public void Test1() => Act(new[] { 3, 5, 8, 13 }, 1, new[] { new[] { 3 }, new[] { 5 }, new[] { 8 }, new[] { 13 } });

        [Test(Description = "List: [3, 5, 8, 13] n: 2")]
        [Order(2)]
        public void Test2() => Act(new[] { 3, 5, 8, 13 }, 2, new[] { new[] { 3, 5 }, new[] { 5, 8 }, new[] { 8, 13 } });

        [Test(Description = "List: [3, 5, 8, 13] n: 3")]
        [Order(3)]
        public void Test3() => Act(new[] { 3, 5, 8, 13 }, 3, new[] { new[] { 3, 5, 8 }, new[] { 5, 8, 13 } });

        [Test(Description = "List: [3, 5, 8, 13] n: 4")]
        [Order(4)]
        public void Test4() => Act(new[] { 3, 5, 8, 13 }, 4, new[] { new[] { 3, 5, 8, 13 } });

        [Test(Description = "List: [3, 5, 8, 13] n: 5")]
        [Order(5)]
        public void Test5() => Act(new[] { 3, 5, 8, 13 }, 5, Empty());
    }
}