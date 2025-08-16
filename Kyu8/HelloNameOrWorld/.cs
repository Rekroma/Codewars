namespace Kyu8.HelloNameOrWorld;

public static class Kata
{
    public static string Hello(string name = "")
    {
        return $"Hello, {(string.IsNullOrEmpty(name) ? "World" : char.ToUpper(name[0]) + name.Substring(1).ToLower())}!";
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.Hello("jEFF"), Is.EqualTo("Hello, Jeff!"));
        Assert.That(Kata.Hello("tonY"), Is.EqualTo("Hello, Tony!"));
        Assert.That(Kata.Hello("Alicia"), Is.EqualTo("Hello, Alicia!"));
        Assert.That(Kata.Hello("vasya"), Is.EqualTo("Hello, Vasya!"));
        Assert.That(Kata.Hello("JOHN"), Is.EqualTo("Hello, John!"));
        Assert.That(Kata.Hello(""), Is.EqualTo("Hello, World!"));
    }

    [Test]
    public void NoArgumentTest()
    {
        Assert.That(Kata.Hello(), Is.EqualTo("Hello, World!"));
    }
}