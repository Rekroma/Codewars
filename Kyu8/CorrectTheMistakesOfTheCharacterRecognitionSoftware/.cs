namespace Kyu8.CorrectTheMistakesOfTheCharacterRecognitionSoftware;

public class Kata
{
    public static string Correct(string text)
    {
        return text.Replace('5', 'S').Replace('0', 'O').Replace('1', 'I');
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void CorrectTests()
    {
        Assert.That(Kata.Correct("L0ND0N"), Is.EqualTo("LONDON"));
        Assert.That(Kata.Correct("DUBL1N"), Is.EqualTo("DUBLIN"));
        Assert.That(Kata.Correct("51NGAP0RE"), Is.EqualTo("SINGAPORE"));
        Assert.That(Kata.Correct("BUDAPE5T"), Is.EqualTo("BUDAPEST"));
        Assert.That(Kata.Correct("PAR15"), Is.EqualTo("PARIS"));
    }
}