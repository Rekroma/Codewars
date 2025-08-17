namespace Kyu8.ChuckNorrisVIITrueOrFalseBeginner;

public static class Kata
{
    public static bool IfChuckSaysSo()
    {
        return 0 == 1;
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void OneAndOnlyTest()
    {
        Assert.That(Kata.IfChuckSaysSo(), Is.EqualTo(false));
    }
}