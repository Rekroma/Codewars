using System.Linq;

namespace Kyu8.ReversedStrings;

public static class Kata
{
    public static string Solution(string str)
    {
        return new string(str.ToArray().Reverse().ToArray());
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public void World()
    {
        Assert.That(Kata.Solution("world"), Is.EqualTo("dlrow"));
    }
}