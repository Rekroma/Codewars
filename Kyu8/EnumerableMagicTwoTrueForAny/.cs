using System;
using System.Linq;

namespace Kyu8.EnumerableMagicTwoTrueForAll;

public class Kata
{
    public static bool Any(int[] arr, Func<int, bool> fun)
    {
        return arr.Any(fun);
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.Any(new int[] { 1, 2, 3, 4 }, v => v > 3), Is.True);
        Assert.That(Kata.Any(new int[] { 1, 2, 3, 4 }, v => v > 4), Is.False);
    }
}