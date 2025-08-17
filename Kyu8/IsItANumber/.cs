namespace Kyu8.IsItANumber;

public class CodeWars
{
    public static bool IsDigit(string s)
    {
        return s != null && double.TryParse(s.Trim(), out _);
    }
}


[TestFixture]
public class SolutionTest
{
    [TestCase("s2324", false)]
    [TestCase("34.65", true)]
    public void BasicTests(
      string input,
      bool expectedResult)
    {
        Assert.That(CodeWars.IsDigit(input), Is.EqualTo(expectedResult));
    }
}