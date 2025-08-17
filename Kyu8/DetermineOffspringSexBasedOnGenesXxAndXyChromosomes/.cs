namespace Kyu8.DetermineOffspringSexBasedOnGenesXxAndXyChromosomes;

public class Kata
{
    public static string ChromosomeCheck(string sperm)
    {
        return sperm[0] == sperm[1] ? "Congratulations! You're going to have a daughter." : "Congratulations! You're going to have a son.";
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.ChromosomeCheck("XY"), Is.EqualTo("Congratulations! You're going to have a son."));
        Assert.That(Kata.ChromosomeCheck("XX"), Is.EqualTo("Congratulations! You're going to have a daughter."));
    }
}