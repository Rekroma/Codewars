using System.Linq;

namespace Kyu7.TwoToOne;

public class TwoToOne
{
    public static string Longest(string s1, string s2)
    {
        return string.Join("", (s1 + s2).Distinct().OrderBy(x => x));
    }
}


[TestFixture]
public static class TwoToOneTests
{

    [Test]
    public static void test1()
    {
        Assert.That(TwoToOne.Longest("aretheyhere", "yestheyarehere"), Is.EqualTo("aehrsty"));
        Assert.That(TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"), Is.EqualTo("abcdefghilnoprstu"));
        Assert.That(TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"), Is.EqualTo("acefghilmnoprstuy"));
    }
}