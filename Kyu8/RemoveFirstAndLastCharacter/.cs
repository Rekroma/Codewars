namespace Kyu8.RemoveFirstAndLastCharacter;

public class Kata
{
    public static string Remove_char(string s)
    {
        return s.Substring(1, (s.Length - 2));
    }
}


[TestFixture]
public class Test
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(Kata.Remove_char("eloquent"), Is.EqualTo("loquen").IgnoreCase);
        Assert.That(Kata.Remove_char("country"), Is.EqualTo("ountr").IgnoreCase);
        Assert.That(Kata.Remove_char("person"), Is.EqualTo("erso").IgnoreCase);
        Assert.That(Kata.Remove_char("place"), Is.EqualTo("lac").IgnoreCase);
        Assert.That(Kata.Remove_char("ok"), Is.EqualTo("").IgnoreCase);
    }
}