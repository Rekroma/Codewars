namespace Kyu7.GreenGlassDoor;

public class Kata
{
    public static bool StepThroughWith(string s)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1]) return true;
        }

        return false;
    }
}


[TestFixture]
public class SolutionTest
{
    [TestCase("moon", ExpectedResult = true)]
    [TestCase("test", ExpectedResult = false)]
    [TestCase("glasses", ExpectedResult = true)]
    [TestCase("airplane", ExpectedResult = false)]
    [TestCase("free", ExpectedResult = true)]
    [TestCase("branch", ExpectedResult = false)]
    [TestCase("aardvark", ExpectedResult = true)]
    public bool Should_Work_SomeExamples(string s) => Kata.StepThroughWith(s);
}