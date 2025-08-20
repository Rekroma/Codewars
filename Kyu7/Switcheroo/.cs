using System.Linq;

namespace Kyu7.Switcheroo;

public class Kata
{
    public static string Switcheroo(string x)
    {
        return string.Join("", x.Select(c => c == 'a' ? 'b' : c == 'b' ? 'a' : c));
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Switcheroo("abc"), Is.EqualTo("bac"));
        Assert.That(Kata.Switcheroo("aaabcccbaaa"), Is.EqualTo("bbbacccabbb"));
        Assert.That(Kata.Switcheroo("ccccc"), Is.EqualTo("ccccc"));
    }
}