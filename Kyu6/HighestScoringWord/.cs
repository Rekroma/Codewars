namespace Kyu6.HighestScoringWord;

public class Kata
{
    public static string High(string s)
    {
        string abc = "0abcdefghijklmnopqrstuvwxyz";
        int stringRecord = 0;
        string recordString = "";

        foreach (string s2 in s.Split())
        {
            int stringScore = 0;

            for (int i = 0; i < s2.Length; i++)
            {
                stringScore += abc.IndexOf(s2[i]);
            }
            if (stringScore > stringRecord)
            {
                stringRecord = stringScore; recordString = s2;
            }
        }

        return recordString;
    }
}


[TestFixture]
public class Sample_Tests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("man i need a taxi up to ubud").Returns("taxi");
            yield return new TestCaseData("what time are we climbing up to the volcano").Returns("volcano");
            yield return new TestCaseData("take me to semynak").Returns("semynak");
            yield return new TestCaseData("aa b").Returns("aa");
            yield return new TestCaseData("b aa").Returns("b");
            yield return new TestCaseData("bb d").Returns("bb");
            yield return new TestCaseData("d bb").Returns("d");
            yield return new TestCaseData("aaa b").Returns("aaa");
        }
    }

    [Test, TestCaseSource("testCases")]
    public string Test(string s) => Kata.High(s);
}
