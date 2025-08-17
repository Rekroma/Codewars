namespace Kyu8.JennysSecretMessage;

public static class Kata
{
    public static string greet(string name)
    {
        return name == "Johnny" ? "Hello, my love!" : "Hello, " + name + "!";
    }
}


[TestFixture]
public class JennysGreeting
{
    [Test]
    [Order(1)]
    public static void ShouldGreetJimNormally()
    {
        Assert.That(Kata.greet("Jim"), Is.EqualTo("Hello, Jim!"));
    }
    [Test]
    [Order(2)]
    public static void ShouldGreetJaneNormally()
    {
        Assert.That(Kata.greet("Jane"), Is.EqualTo("Hello, Jane!"));
    }
    [Test]
    [Order(3)]
    public static void ShouldGreetSimonNormally()
    {
        Assert.That(Kata.greet("Simon"), Is.EqualTo("Hello, Simon!"));
    }

    [Test]
    [Order(4)]
    public static void ShouldGreetJohnnySpecially()
    {
        Assert.That(Kata.greet("Johnny"), Is.EqualTo("Hello, my love!"));
    }
}