using System.Linq;

namespace Kyu8.NameOnBillboard;

public class Kata
{
    public static double Billboard(string name, double price = 30)
    {
        return Enumerable.Repeat(price, name.Length).Sum();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTests()
    {
        Assertion(600, "Jeong-Ho Aristotelis");
        Assertion(40, "CODEWARS", 5);
    }

    private static void Assertion(double expected, string name, double price = -1)
    {
        double actual = price == -1 ? Kata.Billboard(name) : Kata.Billboard(name, price);
        Assert.That(actual, Is.EqualTo(expected).Within(0.000001),
          $"\n  Name: \"{name}\"\n" +
          $"  Price: {(price == -1 ? 30 : price)}\n\n");
    }
}