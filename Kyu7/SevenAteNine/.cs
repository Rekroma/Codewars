namespace Kyu7.SevenAteNine;

public class Kata
{
    public static string SevenAteNine(string str)
    {
        string res = "" + str[0];

        for (int i = 1; i < str.Length - 1; i++)
        {
            if (str[i] == '9' && str[i - 1] == '7' && str[i + 1] == '7')
            {
                continue;
            }

            else res += str[i];
        }

        return res + (str.Length > 1 ? str[str.Length - 1] : "");
    }
}


[TestFixture]
public class KataTests
{
    [TestCase("165561786121789797", "16556178612178977")]
    [TestCase("797", "77")]
    [TestCase("7979797", "7777")]
    public void ExampleTests(string input, string expected)
    {
        Assert.That(Kata.SevenAteNine(input), Is.EqualTo(expected));
    }
}