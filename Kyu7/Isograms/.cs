namespace Kyu7.Isograms;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < str.Length; j++)
            {
                if (char.ToLower(str[i]) == char.ToLower(str[j]))
                {
                    return false;
                }
            }
        }

        return true;
    }
}


[TestFixture]
public class BasicTests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("Dermatoglyphics").Returns(true);
            yield return new TestCaseData("isogram").Returns(true);
            yield return new TestCaseData("moose").Returns(false);
            yield return new TestCaseData("isIsogram").Returns(false);
            yield return new TestCaseData("aba").Returns(false);
            yield return new TestCaseData("moOse").Returns(false);
            yield return new TestCaseData("thumbscrewjapingly").Returns(true);
            yield return new TestCaseData("").Returns(true);
        }
    }

    [Test, TestCaseSource("testCases")]
    public bool Test(string str) => Kata.IsIsogram(str);
}