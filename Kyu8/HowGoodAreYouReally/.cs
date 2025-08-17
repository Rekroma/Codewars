using System.Linq;

namespace Kyu8.HowGoodAreYouReally;

public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        return ClassPoints.Average() < YourPoints;
    }
}


[TestFixture]
public class Tests
{
    private static void DoTest(int[] grades, int userGrade, bool expected)
    {
        String message = "your grade = " + userGrade + "; class grades = {" + String.Join(", ", grades) + "}";
        bool actual = Kata.BetterThanAverage(grades, userGrade);
        Assert.That(actual, Is.EqualTo(expected), message);
    }

    [Test]
    public static void FixedTests()
    {
        DoTest(new int[] { 2, 3 }, 5, true);
        DoTest(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, true);
        DoTest(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, true);
        DoTest(new int[] { 100, 90 }, 11, false);
    }
}