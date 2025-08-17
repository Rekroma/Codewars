namespace Kyu8.GetAsciiValueOfCharacter;

public static class Kata
{
    public static int GetASCII(char c)
    {
        return (int)c;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.GetASCII('A'), Is.EqualTo(65));
        Assert.That(Kata.GetASCII(' '), Is.EqualTo(32));
        Assert.That(Kata.GetASCII('!'), Is.EqualTo(33));
    }
}