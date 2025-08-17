using System.Text.RegularExpressions;

namespace Kyu8.AStrangeTripToTheMarket;

public static class Kata
{
    public static bool IsLockNessMonster(string sentence)
    {
        return Regex.IsMatch(sentence.ToLower(), "tree fiddy") || Regex.IsMatch(sentence, "3.50");
    }
}


[TestFixture]
public class KataTests
{

    [Category("Happy Path")]
    [Order(1)]
    [TestCase("Your girlscout cookies are ready to ship. Your total comes to tree fiddy")]
    public void HappyTest(string sentence)
    {
        Assert.That(Kata.IsLockNessMonster(sentence), Is.True, sentence);
    }

    [Category("Sad Path")]
    [Order(2)]
    [TestCase("Yo, I heard you were on the lookout for Nessie. Let me know if you need assistance.")]
    public void SadTests(string sentence)
    {
        Assert.That(Kata.IsLockNessMonster(sentence), Is.False, sentence);
    }
}