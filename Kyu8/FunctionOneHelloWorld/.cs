namespace Kyu8.FunctionOneHelloWorld;

public static class Kata
{
    public static string greet() => "hello world!";
}


[TestFixture]
public class GreetTest
{
    [Test]
    public void ShouldReturnHelloWorld()
    {
        Assert.That(Kata.greet(), Is.EqualTo("hello world!"));
    }
}