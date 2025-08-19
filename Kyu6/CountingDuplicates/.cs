using System.Linq;

namespace Kyu6.CountingDuplicates;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        return str.ToLower().GroupBy(c => c).Count(g => g.Count() > 1);
    }
}


[TestFixture]
public class KataTest
{
    [Test, Order(1)]
    public void KataTests()
    {
        Assert.That(Kata.DuplicateCount(""), Is.EqualTo(0));
        Assert.That(Kata.DuplicateCount("abcde"), Is.EqualTo(0));
        Assert.That(Kata.DuplicateCount("aabbcde"), Is.EqualTo(2));
        Assert.That(Kata.DuplicateCount("aabBcde"), Is.EqualTo(2), "should ignore case");
        Assert.That(Kata.DuplicateCount("Indivisibility"), Is.EqualTo(1));
        Assert.That(Kata.DuplicateCount("Indivisibilities"), Is.EqualTo(2), "characters may not be adjacent");
    }
}