namespace Kyu8.SumTheStrings;

public static class Program
{
    public static string StringsSum(string s1, string s2)
    {
        return (int.Parse(string.IsNullOrEmpty(s1) ? "0" : s1) + int.Parse(string.IsNullOrEmpty(s2) ? "0" : s2)).ToString();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test(Description = "Tests")]
    public void Tests()
    {
        Assert.That(Program.StringsSum("4", "5"), Is.EqualTo("9"));
        Assert.That(Program.StringsSum("34", "5"), Is.EqualTo("39"));
        Assert.That(Program.StringsSum("", "9"), Is.EqualTo("9"));
        Assert.That(Program.StringsSum("9", ""), Is.EqualTo("9"));
        Assert.That(Program.StringsSum("", ""), Is.EqualTo("0"));
    }
}