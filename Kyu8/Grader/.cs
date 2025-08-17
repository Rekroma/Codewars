namespace Kyu8.Grader;

public class Kata
{
    public static char Grader(double score)
    {
        if (score > 1 || score < 0.6) return 'F';
        if (score >= 0.9) return 'A';
        if (score >= 0.8) return 'B';
        if (score >= 0.7) return 'C';
        else return 'D';
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [TestCase(0.7, ExpectedResult = 'C')]
    [TestCase(0.9, ExpectedResult = 'A')]
    [TestCase(0.6, ExpectedResult = 'D')]
    public static char FixedTest(double score)
    {
        return Kata.Grader(score);
    }
}