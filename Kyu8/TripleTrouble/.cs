using System;
using System.Text;

namespace Kyu8.TripleTrouble;

public class Kata
{
    public static string TripleTrouble(string one, string two, string three)
    {
        StringBuilder sb = new StringBuilder();
        int length = Math.Min(Math.Min(one.Length, two.Length), three.Length);

        for (int i = 0; i < length; i++)
        {
            sb.Append(one[i]);
            sb.Append(two[i]);
            sb.Append(three[i]);
        }
        return sb.ToString();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.TripleTrouble("this", "test", "lock"), Is.EqualTo("ttlheoiscstk"));
        Assert.That(Kata.TripleTrouble("aa", "bb", "cc"), Is.EqualTo("abcabc"));
        Assert.That(Kata.TripleTrouble("Bm", "aa", "tn"), Is.EqualTo("Batman"));
        Assert.That(Kata.TripleTrouble("LLh", "euo", "xtr"), Is.EqualTo("LexLuthor"));
    }
}