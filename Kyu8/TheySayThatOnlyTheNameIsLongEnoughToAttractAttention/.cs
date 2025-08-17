namespace Kyu8.TheySayThatOnlyTheNameIsLongEnoughToAttractAttention;

public class Kata
{
    public static bool IsOpposite(string s1, string s2)
    {
        if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2)) return false;
        if (s1.Length != s2.Length) return false;

        for (int i = 0; i < s1.Length; i++)
        {
            if (char.ToLower(s1[i]) != char.ToLower(s2[i]) ||
                s1[i] == s2[i])
            {
                return false;
            }
        }

        return true;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        Assert.That(Kata.IsOpposite("ab", "AB"), Is.True, "ab, AB => true");
        Assert.That(Kata.IsOpposite("aB", "Ab"), Is.True, "aB, Ab => true");
        Assert.That(Kata.IsOpposite("aBcd", "AbCD"), Is.True, "aBcd, AbCD => true");
        Assert.That(Kata.IsOpposite("aBcde", "AbCD"), Is.False, "aBcde, AbCD => false");
        Assert.That(Kata.IsOpposite("AB", "Ab"), Is.False, "AB, Ab => false");
        Assert.That(Kata.IsOpposite("", ""), Is.False, "String.Empty, String.Empty => false");
    }
}