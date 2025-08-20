using System.Data;

namespace Kyu7.BasicMathAddOrSubtract;

public static class Kata
{
    public static string Calculate(string str)
    {
        return new DataTable().Compute(str.Replace("plus", "+").Replace("minus", "-"), null).ToString();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test(Description = "Basic (fixed) tests")]
    public void BasicTests()
    {
        Test("10", "1plus2plus3plus4");
        Test("-8", "1minus2minus3minus4");
        Test("2", "1plus2plus3minus4");
        Test("-2", "1minus2plus3minus4");
        Test("-1", "1plus2minus3plus4minus5");
    }

    private void Test(string solution, string input)
    {
        Assert.That(Kata.Calculate(input), Is.EqualTo(solution), $"Incorrect answer for input \"{input}\"");
    }
}