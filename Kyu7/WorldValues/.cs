namespace Kyu7.WorlValues;

public class Kata
{
    public static int[] WordValue(string[] a)
    {
        string abc = " abcdefghijklmnopqrstuvwxyz";
        int[] values = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                values[i] += abc.IndexOf(a[i][j]);
            }
            values[i] *= (i + 1);
        }

        return values;
    }
}


[TestFixture]
public class SolutionTest
{
    private static IEnumerable<TestCaseData> sampleTestCases
    {
        get
        {
            yield return new TestCaseData(new[] { new string[] { "codewars", "abc", "xyz" } }).Returns(new int[] { 88, 12, 225 });
            yield return new TestCaseData(new[] { new string[] { "abc abc", "abc abc", "abc", "abc" } }).Returns(new int[] { 12, 24, 18, 24 });
        }
    }

    [Test, TestCaseSource("sampleTestCases")]
    public int[] SampleTest(string[] a) => Kata.WordValue(a);
}
