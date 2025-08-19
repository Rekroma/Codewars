namespace Kyu7.StringEndsWith;

public class Kata
{
    public static bool Solution(string str, string ending)
    {
        return str.EndsWith(ending);
    }
}


[TestFixture]
public class SolutionTest
{
    private static object[] sampleTestCases = new object[]
    {
      new object[] {"samurai", "ai", true},
      new object[] {"sumo", "omo", false},
      new object[] {"ninja", "ja", true},
      new object[] {"sensei", "i", true},
      new object[] {"samurai", "ra", false},
      new object[] {"abc", "abcd", false},
      new object[] {"abc", "abc", true},
      new object[] {"abcabc", "bc", true},
      new object[] {"ails", "fails", false},
      new object[] {"fails", "ails", true},
      new object[] {"this", "fails", false},
      new object[] {"abc", "", true},
      new object[] {":-)", ":-(", false},
      new object[] {"!@#$%^&*() :-)", ":-)", true},
      new object[] {"abc\n", "abc", false},
    };

    [Test, TestCaseSource("sampleTestCases")]
    [Order(1)]
    public void SampleTest(string str, string ending, bool expected)
    {
        bool actual = Kata.Solution(str, ending);
        Assert.That(actual, Is.EqualTo(expected));
    }
}