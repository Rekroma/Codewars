using System.Text;

namespace Kyu7.NumbersToLetters;

public class Kata
{
    public static string Switcher(string[] x)
    {
        string abcReversed = "zyxwvutsrqponmlkjihgfedcba!? ";
        StringBuilder result = new StringBuilder();

        foreach (string num in x)
        {
            int index = int.Parse(num) - 1;
            result.Append(abcReversed[index]);
        }

        return result.ToString();
    }
}


[TestFixture]
public class Tests
{
    [Test, Order(1)]
    public void ExampleTest1()
    {
        string expected = "codewars";
        string actual = Kata.Switcher(new string[] { "24", "12", "23", "22", "4", "26", "9", "8" });
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public void ExampleTest2()
    {
        string expected = "btswmdsbd kkw";
        string actual = Kata.Switcher(new string[] { "25", "7", "8", "4", "14", "23", "8", "25", "23", "29", "16", "16", "4" });
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(3)]
    public void ExampleTest3()
    {
        string expected = "wc";
        string actual = Kata.Switcher(new string[] { "4", "24" });
        Assert.That(actual, Is.EqualTo(expected));
    }
}