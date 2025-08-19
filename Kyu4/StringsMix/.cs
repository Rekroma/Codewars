using System;
using System.Linq;
using System.Collections.Generic;

namespace Kyu4.StringsMix;

public class Mixing
{
    public static string Mix(string s1, string s2)
    {
        return string.Join("/",
            Enumerable.Range('a', 26)
                .Select(c => (char)c)
                .Select(ch =>
                {
                    int count1 = s1.Count(x => x == ch);
                    int count2 = s2.Count(x => x == ch);
                    int max = Math.Max(count1, count2);

                    if (max <= 1) return null;

                    string prefix =
                        count1 > count2 ? "1:" :
                        count2 > count1 ? "2:" : "=:";
                    return prefix + new string(ch, max);
                })
                .Where(x => x != null)
                .OrderByDescending(x => x.Length)
                .ThenBy(x =>
                    x.StartsWith("1:") ? 0 :
                    x.StartsWith("2:") ? 1 : 2)
                .ThenBy(x => x)
        );
    }
}


[TestFixture]
public static class MixingTests
{

    [Test]
    public static void test1()
    {
        Assert.That(Mixing.Mix("Are they here", "yes, they are here"), Is.EqualTo("2:eeeee/2:yy/=:hh/=:rr"));
        Assert.That(Mixing.Mix("looping is fun but dangerous", "less dangerous than coding"), Is.EqualTo("1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg"));
        Assert.That(Mixing.Mix(" In many languages", " there's a pair of functions"), Is.EqualTo("1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt"));
        Assert.That(Mixing.Mix("Lords of the Fallen", "gamekult"), Is.EqualTo("1:ee/1:ll/1:oo"));
        Assert.That(Mixing.Mix("codewars", "codewars"), Is.EqualTo(""));
        Assert.That(Mixing.Mix("A generation must confront the looming ", "codewarrs"), Is.EqualTo("1:nnnnn/1:ooooo/1:tttt/1:eee/1:gg/1:ii/1:mm/=:rr"));
    }
}