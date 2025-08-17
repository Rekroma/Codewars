using System;

namespace Kyu8.WelcomeToTheCity;

public class Kata
{
    public static string SayHello(string[] name, string city, string state)
    {
        return $"Hello, {String.Join(" ", name)}! Welcome to {city}, {state}!";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        string expected = "Hello, John Smith! Welcome to Phoenix, Arizona!";
        Assert.That(Kata.SayHello(new string[] { "John", "Smith" }, "Phoenix", "Arizona"), Is.EqualTo(expected));
    }
}