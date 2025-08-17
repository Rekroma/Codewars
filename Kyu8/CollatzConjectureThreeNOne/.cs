namespace Kyu8.CollatzConjectureThreeNOne;

public class Kata
{
    public static uint Hotpo(uint n)
    {
        uint steps = 0;

        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }
            steps++;
        }

        return steps;
    }
}


[TestFixture]
public class SolutionTest
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(1u).Returns(0u);
            yield return new TestCaseData(5u).Returns(5u);
            yield return new TestCaseData(6u).Returns(8u);
            yield return new TestCaseData(23u).Returns(15u);
        }
    }

    [Test, TestCaseSource("testCases")]
    public uint SampleTest(uint n) => Kata.Hotpo(n);
}
