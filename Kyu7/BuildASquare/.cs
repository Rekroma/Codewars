
namespace Kyu7.BuildASquare;

public static class Kata
{
    public static string GenerateShape(int n)
    {
        string str = "";

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                str += "+";
            }
            if (i != n - 1) str += "\n";
        }

        return str;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.GenerateShape(0), Is.EqualTo(""));
        Assert.That(Kata.GenerateShape(1), Is.EqualTo("+"));
        Assert.That(Kata.GenerateShape(2), Is.EqualTo("++\n++"));
        Assert.That(Kata.GenerateShape(3), Is.EqualTo("+++\n+++\n+++"));
    }
}