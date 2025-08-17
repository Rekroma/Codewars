namespace Kyu8.ExclusiveOrXorLogicalOperator;

public class Kata
{
    public static bool Xor(bool a, bool b)
    {
        return a != b;
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Xor(false, false), Is.False, "false xor false should be false");
        Assert.That(Kata.Xor(true, false), Is.True, "true xor false should be true");
        Assert.That(Kata.Xor(false, true), Is.True, "false xor true should be true");
        Assert.That(Kata.Xor(true, true), Is.False, "true xor true should be false");
    }
}