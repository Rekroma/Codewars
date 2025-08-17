using System.Linq;

namespace Kyu8.KataExampleTwist;

public static class Kata
{
    public static string[] Websites { get; } = Enumerable.Repeat("codewars", 1000).ToArray();
}


[TestFixture]
public static class KataTests
{
    [Test]
    public static void Tests()
    {
        Assert.That(Kata.Websites, Is.Not.Null);
        Assert.That(Kata.Websites.Length, Is.EqualTo(1000));
        Assert.That(Kata.Websites.GetType().GetElementType(), Is.EqualTo(typeof(System.String)));
        Assert.That(Array.TrueForAll(Kata.Websites, (v) => v == "codewars"));
    }
}