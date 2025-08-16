namespace Kyu8.IsHeGonnaSurvive;

class Kata
{
    public static bool Hero(int bullets, int dragons)
    {
        return bullets >= 2 * dragons;
    }
}


[TestFixture]
class Tests
{
    [TestCase(10, 5)]
    [TestCase(100, 40)]
    public void ATrueHero(int bullets, int dragons)
    {
        var actual = Kata.Hero(bullets, dragons);
        Assert.That(actual, Is.True);
    }

    [TestCase(4, 5)]
    [TestCase(1500, 751)]
    [TestCase(0, 1)]
    [TestCase(7, 4)]
    public void AFalseHero(int bullets, int dragons)
    {
        var actual = Kata.Hero(bullets, dragons);
        Assert.That(actual, Is.False);
    }
}