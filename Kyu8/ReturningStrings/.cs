namespace Kyu8.ReturningStrings;

public static class Kata
{
    public static string Greet(string name)
    {
        return $"Hello, {name} how are you doing today?";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
    }
}