namespace Kyu6.MultiplesOfThreeOrFive;

public static class Kata
{
    public static int Solution(int value)
    {
        if (value < 0) return 0;
        int sum = 0;

        for (int i = 0; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public void SampleTests()
    {
        Assertion(expected: 23, input: 10);
        Assertion(expected: 78, input: 20);
        Assertion(expected: 9168, input: 200);
        Assertion(expected: 0, input: 0);
    }

    private static void Assertion(int expected, int input) =>
      Assert.That(
        Kata.Solution(input),
        Is.EqualTo(expected),
        $"Incorrect answer for input={input}"
      );
}