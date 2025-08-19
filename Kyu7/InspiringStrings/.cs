using System.Linq;

namespace Kyu7.InspiringStrings;

public class Kata
{
    public static string LongestWord(string stringOfWords)
    {
        return stringOfWords.Split().ToArray()
          .Select((str, i) => new { str, i })
          .OrderBy(x => x.str.Length)
          .ThenBy(x => x.i)
          .Last().str.ToString();
    }
}


[TestFixture]
public class SolutionTest
{

    private static object[] Basic_Test_Cases = new object[]
    {
      new object[] {"a b c d e fgh", "fgh"},
      new object[] {"one two three", "three"},
      new object[] {"red blue grey", "grey"},
    };

    [Test, TestCaseSource(typeof(SolutionTest), "Basic_Test_Cases")]
    public void Basic_Test(string test, string expected)
    {
        Assert.That(Kata.LongestWord(test), Is.EqualTo(expected));
    }

    // Note: Random tests output user code execution time
}
