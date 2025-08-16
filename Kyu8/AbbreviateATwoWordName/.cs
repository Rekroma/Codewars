namespace Kyu8.AbbreviateATwoWordName;

public class Kata
{
    public static string AbbrevName(string name)
    {
        return $"{name.Split(' ')[0][0]}.{name.Split(' ')[1][0]}".ToUpper();
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    [Order(1)]
    public void BasicTests()
    {
        Assert.That(Kata.AbbrevName("Sam Harris"), Is.EqualTo("S.H"));
        Assert.That(Kata.AbbrevName("Patrick Feenan"), Is.EqualTo("P.F"));
        Assert.That(Kata.AbbrevName("Evan Cole"), Is.EqualTo("E.C"));
        Assert.That(Kata.AbbrevName("P Favuzzi"), Is.EqualTo("P.F"));
        Assert.That(Kata.AbbrevName("David Mendieta"), Is.EqualTo("D.M"));
    }
}