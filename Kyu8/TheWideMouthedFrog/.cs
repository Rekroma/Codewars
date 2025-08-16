namespace Kyu8.TheWideMouthedFrog;

public class Kata
{
    public static string MouthSize(string animal)
    {
        return animal.ToLower() == "alligator" ? "small" : "wide";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.MouthSize("toucan"), Is.EqualTo("wide"));
        Assert.That(Kata.MouthSize("ant bear"), Is.EqualTo("wide"));
        Assert.That(Kata.MouthSize("alligator"), Is.EqualTo("small"));
    }
}