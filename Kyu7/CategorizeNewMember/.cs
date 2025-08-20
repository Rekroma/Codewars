using System.Collections.Generic;

namespace Kyu7.CategorizeNewMember;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i][0] >= 55 && data[i][1] > 7) yield return "Senior";
            else yield return "Open";
        }
    }
}


[TestFixture]
public class KataOpenOrSeniorTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }), Is.EqualTo(new[] { "Open", "Senior", "Open", "Senior" }));
        Assert.That(Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }), Is.EqualTo(new[] { "Open", "Open", "Open", "Open" }));
        Assert.That(Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }), Is.EqualTo(new[] { "Senior", "Open", "Open", "Open" }));
    }
}