using System;
using System.Linq;

namespace Kyu7.MaximumLengthDifference;

public class MaxDiffLength
{
    public static int Mxdiflg(string[] a1, string[] a2)
    {
        return a1.Length == 0 || a2.Length == 0 ? -1 : Math.Max(a1.Max(x => x.Length) - a2.Min(x => x.Length), a2.Max(x => x.Length) - a1.Min(x => x.Length));
    }
}


[TestFixture]
public static class MaxDiffLengthTests
{

    [Test]
    public static void test1()
    {
        string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
        string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
        Assert.That(MaxDiffLength.Mxdiflg(s1, s2), Is.EqualTo(13));
    }

}
