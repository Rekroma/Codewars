namespace Kyu7.GetTheMiddleCharacter;

public class Kata
{
    public static string GetMiddle(string s)
    {
        return s.Length % 2 == 0 ? $"{s[(s.Length / 2) - 1]}{s[(s.Length / 2)]}" : $"{s[s.Length / 2]}";
    }
}


[TestFixture]
public class GetMiddleTest
{
    [Test, Order(1)]
    public void GenericTests()
    {
        Assert.That(Kata.GetMiddle("test"), Is.EqualTo("es"));
        Assert.That(Kata.GetMiddle("testing"), Is.EqualTo("t"));
        Assert.That(Kata.GetMiddle("middle"), Is.EqualTo("dd"));
        Assert.That(Kata.GetMiddle("A"), Is.EqualTo("A"));
    }
}