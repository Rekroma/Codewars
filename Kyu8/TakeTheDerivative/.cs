namespace Kyu8.TakeTheDerivative;

public class Kata
{
    public static string Derive(double coefficient, double exponent)
    {
        return (coefficient * exponent) + "x^" + (exponent - 1);
    }
}


[TestFixture]
public class SolutionTest
{

    private static object[] Basic_Test_Cases = new object[]
    {
      new object[] {7, 8, "56x^7"},
      new object[] {5, 9, "45x^8"},
    };

    [Test, TestCaseSource(typeof(SolutionTest), "Basic_Test_Cases")]
    public void Basic_Test(double coefficient, double exponent, string expected)
    {
        Assert.That(Kata.Derive(coefficient, exponent), Is.EqualTo(expected));
    }
}