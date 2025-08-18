using System.Linq;
using System.Collections.Generic;

namespace Kyu7.FriendOrFoe;

public static class Kata
{
    public static IEnumerable<string> FriendOrFoe(string[] names)
    {
        return names.Where(s => s.Length == 4);
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    [TestCase(
        new[] { "Mark", "Jimmy", "Abel", "Amanda" },
        new[] { "Mark", "Abel" }
    )]
    [TestCase(
        new[] { "Peter", "Anna", "Michael" },
        new[] { "Anna" }
    )]
    [TestCase(
        new[] { "Linus", "Beau", "Azul" },
        new[] { "Beau", "Azul" }
    )]
    [TestCase(
        new[] { "Joe", "Stephen", "Peter" },
        new String[] { }
    )]
    [TestCase(
        new String[] { },
        new String[] { }
    )]
    public void SampleTests(string[] names, IEnumerable<string> expected)
    {
        Assert.That(Kata.FriendOrFoe(names), Is.EqualTo(expected));
    }
}