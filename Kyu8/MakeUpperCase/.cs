namespace Kyu8.MakeUpperCase;

public class Kata
{
    public static string MakeUpperCase(string str)
    {
        return str.ToUpper();
    }
}


[TestFixture]
public class MakeUpperCaseTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.MakeUpperCase("hello"), Is.EqualTo("HELLO"));
    }
}