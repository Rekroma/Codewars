using System.Linq;

namespace Kyu7.StrongNumberSpecialNumberSeriesTwo;

class Kata
{
    public static string StrongNumber(int number)
    {
        return number.ToString().Select(c => Factorial((int)char.GetNumericValue(c))).Sum().ToString() == number.ToString() ? "STRONG!!!!" : "Not Strong !!";
    }

    public static int Factorial(int n)
    {
        return n == 0 ? 1 : n * Factorial(n - 1);
    }
}


[TestFixture]
class Tests
{
    [TestCase(1, "STRONG!!!!")]
    [TestCase(2, "STRONG!!!!")]
    [TestCase(145, "STRONG!!!!")]
    [TestCase(7, "Not Strong !!")]
    [TestCase(93, "Not Strong !!")]
    [TestCase(185, "Not Strong !!")]
    public void BasicTests(int input, string expected)
    {
        Assert.That(Kata.StrongNumber(input), Is.EqualTo(expected));
    }
}