using System;
using System.Linq;

namespace Kyu7.LeastLarger;

public class Kata
{
    public static int LeastLarger(int[] a, int i)
    {
        return a.Length <= i || !a.Any(x => x > a[i]) ? -1 : Array.IndexOf(a, a.Where(x => x > a[i]).Min());
    }
}


[TestFixture, Description("Fixed Tests")]
public class FixedTests
{
    [Test, Description("No Least Larger Exists (=> Return -1)"), Order(1)]
    public void NoLeastLargerExists() =>
        Assert.That(Kata.LeastLarger(new[] { 4, 1, 3, 5, 6 }, 4), Is.EqualTo(-1), "Incorrect output for Kata.LeastLarger(new[] { 4, 1, 3, 5, 6 }, 4):");

    [Test, Description("Least Larger Exists"), Order(2)]
    public void LeastLargerExists()
    {
        Assert.That(Kata.LeastLarger(new[] { 1, 3, 5, 2, 4 }, 0), Is.EqualTo(3), "Incorrect output for Kata.LeastLarger(new[] { 1, 3, 5, 2, 4 }, 0):");
        Assert.That(Kata.LeastLarger(new[] { 4, 1, 3, 5, 6 }, 0), Is.EqualTo(3), "Incorrect output for Kata.LeastLarger(new[] { 4, 1, 3, 5, 6 }, 0):");
    }
}