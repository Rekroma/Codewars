namespace Kyu8.DrawStairs;

public class Kata
{
    public static string DrawStairs(int n)
    {
        string stairs = "";

        for (int i = 1; i < n; i++)
        {
            stairs += "I\n" + new string(' ', i);
        }

        return stairs + "I";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTests()
    {
        Assert.That(Kata.DrawStairs(1), Is.EqualTo("I"));
        Assert.That(Kata.DrawStairs(2), Is.EqualTo("I\n I"));
        Assert.That(Kata.DrawStairs(3), Is.EqualTo("I\n I\n  I"));
        Assert.That(Kata.DrawStairs(4), Is.EqualTo("I\n I\n  I\n   I"));
    }
}