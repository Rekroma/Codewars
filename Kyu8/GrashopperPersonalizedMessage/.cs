namespace Kyu8.PersonalizedMessage;

public class Kata
{
    public static string Greet(string name, string owner)
    {
        return name == owner ? "Hello boss" : "Hello guest";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Kata.Greet("Daniel", "Daniel"), Is.EqualTo("Hello boss"));
        Assert.That(Kata.Greet("Greg", "Daniel"), Is.EqualTo("Hello guest"));
    }
}