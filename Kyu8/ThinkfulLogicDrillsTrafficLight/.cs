namespace Kyu8.ThinkfulLogicDrillsTraficLight;

public class Kata
{
    public static string UpdateLight(string current)
    {
        return current == "green" ? "yellow" : current == "yellow" ? "red" : "green";
    }
}


[TestFixture]
public class Tests
{
    [TestCase("green", "yellow")]
    [TestCase("yellow", "red")]
    [TestCase("red", "green")]
    public void BasicTests(string s, string expected)
    {
        Assert.That(Kata.UpdateLight(s), Is.EqualTo(expected));
    }
}