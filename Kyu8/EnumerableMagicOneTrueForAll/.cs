using System;
using System.Linq;

namespace Kyu8.EnumerableMagicOneTrueForAll;

public class Kata
{
    public static bool All(int[] arr, Func<int, bool> fun)
    {
        return arr.Length == 0 || arr.All(fun);
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.All(new int[] { 1, 2, 3, 4, 5 }, v => v < 9), Is.True);
        Assert.That(Kata.All(new int[] { 1, 2, 3, 4, 5 }, v => v > 9), Is.False);
    }
}