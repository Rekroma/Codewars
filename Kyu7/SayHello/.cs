namespace Kyu7.SayHello;

public class Greetings
{
    public static string greet(string name)
    {
        return string.IsNullOrEmpty(name) ? null : "hello " + name + "!";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Greetings.greet("Niks"), Is.EqualTo("hello Niks!"));
        Assert.That(Greetings.greet(""), Is.Null);
        Assert.That(Greetings.greet(null), Is.Null);
    }
}