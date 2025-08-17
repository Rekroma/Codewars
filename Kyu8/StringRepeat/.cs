using System.Linq;

namespace Kyu8.StringRepeat;

public static class Program
{
    public static string RepeatStr(int n, string s)
    {
        return string.Concat(Enumerable.Repeat(s, n));
    }
}


[TestFixture]
public class SolutionTest
{
    [Test(Description = "Fixed Tests"), Order(1)]
    public void FixedTests()
    {
        Assert.That(Program.RepeatStr(3, "*"), Is.EqualTo("***"));
        Assert.That(Program.RepeatStr(5, "#"), Is.EqualTo("#####"));
        Assert.That(Program.RepeatStr(2, "ha "), Is.EqualTo("ha ha "));
        Assert.That(Program.RepeatStr(3, ""), Is.EqualTo(""));
        Assert.That(Program.RepeatStr(0, "mystery"), Is.EqualTo(""));
        Assert.That(Program.RepeatStr(0, ""), Is.EqualTo(""));
        Assert.That(Program.RepeatStr(6, "I"), Is.EqualTo("IIIIII"));
        Assert.That(Program.RepeatStr(5, "Hello"), Is.EqualTo("HelloHelloHelloHelloHello"));
    }
}
