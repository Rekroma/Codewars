using System.Linq;

namespace Kyu6.DetectPangram;

public static class Kata
{
    public static bool IsPangram(string str)
    {
        return "abcdefghijklmnopqrstuvwxyz".All(c => str.ToLower().Contains(c));
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public void SampleTests()
    {
        Assert.That(Kata.IsPangram("The quick brown fox jumps over the lazy dog."), Is.EqualTo(true));
    }
}