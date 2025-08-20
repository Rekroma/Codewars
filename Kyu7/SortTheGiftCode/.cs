using System.Linq;

namespace Kyu7.SortTheGiftCode;

public class Kata
{
    public static string SortGiftCode(string code)
    {
        return string.Join("", code.ToCharArray().OrderBy(x => x));
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.SortGiftCode("abcdef"), Is.EqualTo("abcdef"));
        Assert.That(Kata.SortGiftCode("pqksuvy"), Is.EqualTo("kpqsuvy"));
        Assert.That(Kata.SortGiftCode("zyxwvutsrqponmlkjihgfedcba"), Is.EqualTo("abcdefghijklmnopqrstuvwxyz"));
    }
}