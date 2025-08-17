namespace Kyu8.ConvertBooleanValuesToStringsYesOrNo;

public static class Kata
{
    public static string boolToWord(bool word)
    {
        return word ? "Yes" : "No";
    }
}


[TestFixture]
public class boolToWordTest
{

    [Test]
    public void boolToWordReturned1()
    {
        Assert.That(Kata.boolToWord(true), Is.EqualTo("Yes"), "Incorrect answer for word=\"true\"");
    }

    [Test]
    public void boolToWordReturned2()
    {
        Assert.That(Kata.boolToWord(false), Is.EqualTo("No"), "Incorrect answer for word=\"false\"");
    }

    [Test]
    public void boolToWordReturned3()
    {
        Assert.That(Kata.boolToWord(true), Is.EqualTo("Yes"), "Incorrect answer for word=\"true\"");
    }
}