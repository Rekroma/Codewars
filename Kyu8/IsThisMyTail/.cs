namespace Kyu8.IsThisMyTail;

public class Kata
{
    public static bool CorrectTail(string body, string tail)
    {
        return body.EndsWith(tail);
    }
}


[TestFixture]
public class Sample_Test
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("Fox", "x").Returns(true);
            yield return new TestCaseData("Rhino", "o").Returns(true);
            yield return new TestCaseData("Meerkat", "t").Returns(true);
            yield return new TestCaseData("Emu", "t").Returns(false);
            yield return new TestCaseData("Badger", "s").Returns(false);
            yield return new TestCaseData("Giraffe", "d").Returns(false);
        }
    }

    [Test, TestCaseSource("testCases")]
    public bool Test(string body, string tail) => Kata.CorrectTail(body, tail);
}