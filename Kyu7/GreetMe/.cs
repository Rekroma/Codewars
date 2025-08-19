namespace Kyu7.GreetMe;

public static class Kata
{
    public static string Greet(string name)
    {
        return $"Hello {char.ToUpper(name[0]) + name.Substring(1).ToLower()}!";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        // Additional sample tests are left as an exercise to the user.
        // Feel free to add more tests using the "Assert.That(actual, Is.EqualTo(expected))" syntax
        Assert.That(Kata.Greet("riley"), Is.EqualTo("Hello Riley!"));
    }
}