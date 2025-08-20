using System.Linq;

namespace Kyu7.SortByLastChar;

public static class Kata
{
    public static string[] Last(string x)
    {
        return x.Split().OrderBy(word => word.Last().ToString()).ToArray();
    }
}


public class KataTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Last("abc cba cab"), Is.EqualTo(new[] { "cba", "cab", "abc" }));
        Assert.That(Kata.Last("bbb ccc aaa ddd"), Is.EqualTo(new[] { "aaa", "bbb", "ccc", "ddd" }));
        Assert.That(Kata.Last("co de wa rs"), Is.EqualTo(new[] { "wa", "de", "co", "rs" }));
        Assert.That(Kata.Last("axa ava asa"), Is.EqualTo(new[] { "axa", "ava", "asa" }));

        Assert.That(Kata.Last("man i need a taxi up to ubud"), Is.EqualTo(new[] { "a", "need", "ubud", "i", "taxi", "man", "to", "up" }));

        Assert.That(Kata.Last("what time are we climbing up the volcano"), Is.EqualTo(new[] { "time", "are", "we", "the", "climbing", "volcano", "up", "what" }));

        Assert.That(Kata.Last("take me to semynak"), Is.EqualTo(new[] { "take", "me", "semynak", "to" }));

        Assert.That(Kata.Last("massage yes massage yes massage"), Is.EqualTo(new[] { "massage", "massage", "massage", "yes", "yes" }));

        Assert.That(Kata.Last("take bintang and a dance please"), Is.EqualTo(new[] { "a", "and", "take", "dance", "please", "bintang" }));
    }
}