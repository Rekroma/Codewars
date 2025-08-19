using System;

namespace Kyu7.BinaryAddition;

public static class Kata
{
    public static string AddBinary(int a, int b)
    {
        return Convert.ToString(a + b, 2);
    }
}


[TestFixture]
public class AddBinaryTest
{
    [Test]
    public void TestExample()
    {
        Assert.That(Kata.AddBinary(1, 2), Is.EqualTo("11"), "Should return \"11\" for 1 + 2");
    }
}