using System;

namespace Kyu8.StringTemplatesBugFixingFive;

public static class Kata
{
    public static string buildString(string[] args)
    {
        return String.Format("I like {0}!", String.Join(", ", args));
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public static void FixedTests()
    {
        Assert.That(Kata.buildString(new string[] { "Cheese", "Milk", "Chocolate" }), Is.EqualTo("I like Cheese, Milk, Chocolate!"));
        Assert.That(Kata.buildString(new string[] { "Cheese", "Milk" }), Is.EqualTo("I like Cheese, Milk!"));
        Assert.That(Kata.buildString(new string[] { "Chocolate" }), Is.EqualTo("I like Chocolate!"));
    }
}