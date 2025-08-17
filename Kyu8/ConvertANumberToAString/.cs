namespace Kyu8.ConvertANumberToAString;

public class Kata
{
    public static string NumberToString(int num)
    {
        return num.ToString();
    }
}


[TestFixture]
public class KataTests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(67).Returns("67");
            yield return new TestCaseData(79585).Returns("79585");
            yield return new TestCaseData(1 + 2).Returns("3");
            yield return new TestCaseData(1 - 2).Returns("-1");
            yield return new TestCaseData(0).Returns("0");
        }
    }

    [Test, TestCaseSource("testCases")]
    public string Test(int num) => Kata.NumberToString(num);
}