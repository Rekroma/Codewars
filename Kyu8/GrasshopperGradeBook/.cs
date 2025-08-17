namespace Kyu8.GrasshopperGradeBook;

public class Kata
{
    public static char GetGrade(int s1, int s2, int s3)
    {
        int score = (s1 + s2 + s3) / 3;
        if (90 <= score && score <= 100) return 'A';
        if (80 <= score && score < 90) return 'B';
        if (70 <= score && score < 80) return 'C';
        if (60 <= score && score < 70) return 'D';
        else return 'F';
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [TestCase(95, 90, 93, ExpectedResult = 'A')]
    [TestCase(70, 70, 100, ExpectedResult = 'B')]
    [TestCase(70, 71, 72, ExpectedResult = 'C')]
    [TestCase(65, 66, 60, ExpectedResult = 'D')]
    [TestCase(32, 15, 21, ExpectedResult = 'F')]
    public static char FixedTests(int n1, int n2, int n3)
    {
        return Kata.GetGrade(n1, n2, n3);
    }
}