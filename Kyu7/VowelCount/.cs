namespace Kyu7.VowelCount;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        string vowels = "AEIOUaeiou";

        foreach (char c in str)
        {
            if (vowels.Contains(c)) vowelCount++;
        }

        return vowelCount;
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void TestCase1()
    {
        Assert.That(Kata.GetVowelCount("abracadabra"), Is.EqualTo(5), "Incorrect answer for str = \"abracadabra\"");
    }
}