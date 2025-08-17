namespace Kyu8.GrasshopperDebugSayHello;

public class Kata
{
    public static string SayHello(string name)
    {
        return $"Hello, {name}";
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [TestCase("Mr. Spock", ExpectedResult = "Hello, Mr. Spock")]
    [TestCase("Captain Kirk", ExpectedResult = "Hello, Captain Kirk")]
    [TestCase("Liutenant Uhura", ExpectedResult = "Hello, Liutenant Uhura")]
    [TestCase("Dr. McCoy", ExpectedResult = "Hello, Dr. McCoy")]
    public static string FixedTest(string name)
    {
        return Kata.SayHello(name);
    }
}