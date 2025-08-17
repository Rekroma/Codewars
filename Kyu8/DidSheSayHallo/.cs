using System.Text.RegularExpressions;

namespace Kyu8.DidSheSayHallo;

public class Kata
{
    public static bool Validate_hello(string greetings)
    {
        return Regex.IsMatch(greetings.ToLower(), "(hello|ciao|salut|hallo|hola|ahoj|czesc)");
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void Test1()
    {
        Assert.That(Kata.ValidateHello("hello"), Is.True);
        Assert.That(Kata.ValidateHello("ciao bella!"), Is.True);
        Assert.That(Kata.ValidateHello("salut"), Is.True);
        Assert.That(Kata.ValidateHello("hallo, salut"), Is.True);
        Assert.That(Kata.ValidateHello("hombre! Hola!"), Is.True);
        Assert.That(Kata.ValidateHello("Hallo, wie geht's dir?"), Is.True);
        Assert.That(Kata.ValidateHello("AHOJ!"), Is.True);
        Assert.That(Kata.ValidateHello("czesc"), Is.True);
        Assert.That(Kata.ValidateHello("Ahoj"), Is.True);
        Assert.That(Kata.ValidateHello("meh"), Is.False);
    }
}