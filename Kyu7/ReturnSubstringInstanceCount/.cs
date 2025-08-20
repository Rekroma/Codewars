using System.Text.RegularExpressions;

namespace Kyu7.ReturnSubstringInstanceCount;

public class Kata
{
    public static int SubstringCount(string fullText, string searchText)
    {
        return Regex.Matches(fullText, searchText).Count;
    }
}


[TestFixture]
public class Sample_Tests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("abcdeb", "b").Returns(2);
            yield return new TestCaseData("abcdeb", "a").Returns(1);
            yield return new TestCaseData("ccddeeccddeecc", "cc").Returns(3);
        }
    }

    [Test, TestCaseSource("testCases")]
    public int SampleTest(string fullText, string searchText) => Kata.SubstringCount(fullText, searchText);
}
