namespace Kyu8.ShortLongShort;

public class ShortLongShort
{
    public static string Solution(string a, string b)
    {
        return (a.Length > b.Length) ? (b + a + b) : (a + b + a);
    }
}


[TestFixture]
public class SolutionTests
{
    [Test]
    public void BasicTest()
    {
        Assert.That(ShortLongShort.Solution("1", "22"), Is.EqualTo("1221"));
        Assert.That(ShortLongShort.Solution("22", "1"), Is.EqualTo("1221"));
        Assert.That(ShortLongShort.Solution("232", "1"), Is.EqualTo("12321"));
        Assert.That(ShortLongShort.Solution("232", ""), Is.EqualTo("232"));
        Assert.That(ShortLongShort.Solution("232", "2132"), Is.EqualTo("2322132232"));
    }
}