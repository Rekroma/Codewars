using System.Linq;

namespace Kyu7.DisemvowelTrolls;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        return new string(str.Where(x => !"aeiouAEIOU".Contains(x)).ToArray());
    }
}


[TestFixture]
public class DisemvowelTest
{
    [Test]
    public void ShouldRemoveAllVowels()
    {
        Assert.That(Kata.Disemvowel("This website is for losers LOL!"), Is.EqualTo("Ths wbst s fr lsrs LL!"), "Incorrect answer for input=\"This website is for losers LOL!\"");
    }

    [Test]
    public void MultilineString()
    {
        Assert.That(Kata.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"), Is.EqualTo("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd"), "Incorrect answer for input=\"No offense but,\nYour writing is among the worst I've ever read\"");
    }

    [Test]
    public void OneMoreForGoodMeasure()
    {
        Assert.That(Kata.Disemvowel("What are you, a communist?"), Is.EqualTo("Wht r y,  cmmnst?"), "Incorrect answer for input=\"What are you, a communist?\"");
    }
}