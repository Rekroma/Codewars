using System.Linq;

namespace Kyu5.FirstNonRepeatingCharacter;

public class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        return (s.FirstOrDefault(c => s.Count(x => char.ToLower(x) == char.ToLower(c)) < 2) + "").Trim('\0');
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.FirstNonRepeatingLetter("a"), Is.EqualTo("a"));
        Assert.That(Kata.FirstNonRepeatingLetter("stress"), Is.EqualTo("t"));
        Assert.That(Kata.FirstNonRepeatingLetter("moonmen"), Is.EqualTo("e"));
    }
}
