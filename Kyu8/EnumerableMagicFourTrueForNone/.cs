using System;
using System.Linq;

namespace Kyu8.EnumerableMagicFourTrueForNone;

public class Kata
{
    public static bool None(int[] arr, Func<int, bool> fun)
    {
        return !arr.Any(fun);
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.None(new int[] { 1, 2, 3, 4, 5 }, v => v > 5), Is.True);
        Assert.That(Kata.None(new int[] { 1, 2, 3, 4, 5 }, v => v > 4), Is.False);
    }
}