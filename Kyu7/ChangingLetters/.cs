namespace Kyu7.ChangingLetters;

public static class Kata
{
    public static string Swap(string s)
    {
        string vowels = "aeiouAEIOU";
        string str = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                str += char.ToUpper(s[i]);
            }
            else
            {
                str += s[i];
            }
        }

        return str;
    }
}


[TestFixture]
public class BasicTest
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("HelloWorld!").Returns("HEllOWOrld!");
            yield return new TestCaseData("Sunday").Returns("SUndAy");
        }
    }

    [Test, TestCaseSource("testCases")]
    public string Test(string s) =>
      Kata.Swap(s);
}