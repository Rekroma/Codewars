using System.Text.RegularExpressions;

namespace Kyu6.BreakCamelCase;

public class Kata
{
    public static string BreakCamelCase(string str)
    {
        return Regex.Replace(str, "(?<=[a-zA-Z])(?=[A-Z])", " ");
    }
}


[TestFixture]
public class Sample_Tests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("camelCasing").Returns("camel Casing");
            yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
        }
    }

    [Test, TestCaseSource("testCases")]
    public string Test(string str) => Kata.BreakCamelCase(str);
}