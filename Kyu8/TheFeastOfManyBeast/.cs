namespace Kyu8.TheFeastOfManyBeast;

public class Kata
{
    public static bool Feast(string beast, string dish)
    {
        return beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
    }
}


[TestFixture]
public class Tests
{
    [TestCase("great blue heron", "garlic naan")]
    [TestCase("chickadee", "chocolate cake")]
    [Order(1)]
    public void BasicTestsTrue(string beast, string dish)
    {
        Assert.That(Kata.Feast(beast, dish), Is.True);
    }

    [TestCase("brown bear", "bear claw")]
    [Order(2)]
    public void BasicTestsFalse(string beast, string dish)
    {
        Assert.That(Kata.Feast(beast, dish), Is.False);
    }
}