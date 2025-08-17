namespace Kyu8.ParseNiceIntFromCharProblem;

public class Kata
{
    public static int GetAge(string inputString)
    {
        return inputString[0] - '0';
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.GetAge("3 years old"), Is.EqualTo(3));
        Assert.That(Kata.GetAge("4 years old"), Is.EqualTo(4));
        Assert.That(Kata.GetAge("9 years old"), Is.EqualTo(9));
    }
}