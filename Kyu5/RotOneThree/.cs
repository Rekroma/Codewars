using System.Text;

namespace Kyu5.RotOneThree;

public class Kata
{
    public static string Rot13(string message)
    {
        StringBuilder str = new StringBuilder();

        foreach (char c in message)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                str.Append((char)(offset + (c - offset + 13) % 26));
            }
            else
            {
                str.Append(c);
            }
        }

        return str.ToString();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1), Description("test")]
    public void testTest()
    {
        var actualOutput = Kata.Rot13("test");
        Assert.That(actualOutput, Is.EqualTo("grfg"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", actualOutput));
    }

    [Test, Order(2), Description("Test")]
    public void TestTest()
    {
        var actualOutput = Kata.Rot13("Test");
        Assert.That(actualOutput, Is.EqualTo("Grfg"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", actualOutput));
    }
}