using System;

namespace Kyu8.TheIfFunction;

public class Kata
{
    public static void If(bool condition, Action func1, Action func2)
    {
        (condition ? func1 : func2)();
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public void BasicTest()
    {
        var a = false;

        Kata.If(true, () => a = true, () => a = false);

        Assert.That(a, Is.True, "func1 should be called");
    }
}