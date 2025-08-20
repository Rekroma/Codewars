namespace Kyu7.BandNameGenerator;

public class Kata
{
    public static string BandNameGenerator(string str)
    {
        if (str[0] == str[str.Length - 1]) return char.ToUpper(str[0]) + str.Substring(1) + str.Substring(1);
        else return "The " + char.ToUpper(str[0]) + str.Substring(1);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.BandNameGenerator("knife"), Is.EqualTo("The Knife"));
        Assert.That(Kata.BandNameGenerator("tart"), Is.EqualTo("Tartart"));
        Assert.That(Kata.BandNameGenerator("sandles"), Is.EqualTo("Sandlesandles"));
        Assert.That(Kata.BandNameGenerator("bed"), Is.EqualTo("The Bed"));
    }
}