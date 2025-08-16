namespace Kyu8.Quadrants;

public static class Kata
{
    public static int Quadrant(int x, int y)
    {
        return x > 0 ? (y > 0 ? 1 : 4) : (y > 0 ? 2 : 3);
    }
}


[TestFixture]
public class SolutionTest
{
    static void Act(int x, int y, int expected)
      => Assert.That(Kata.Quadrant(x, y), Is.EqualTo(expected), $"Quadrant( x = {x}, y = {y} )");

    [TestCase(1, 2, 1)]
    [TestCase(3, 5, 1)]
    [TestCase(-10, 100, 2)]
    [TestCase(-1, -9, 3)]
    [TestCase(19, -56, 4)]
    [TestCase(1, 1, 1)]
    [TestCase(-60, -12, 3)]
    public void FixedTests(int x, int y, int expected) => Act(x, y, expected);
}