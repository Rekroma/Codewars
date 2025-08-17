using System.Linq;

namespace Kyu8.GenerateRangeOfIntegers;

public class Kata
{
    public static int[] GenerateRange(int min, int max, int step)
    {
        return Enumerable.Range(0, 1 + (max - min) / step).Select(x => min + x * step).ToArray();
    }
}


[TestFixture]
public class Tests
{
    [TestCase(2, 10, 2, ExpectedResult = new int[] { 2, 4, 6, 8, 10 })]
    public static int[] FixedTest(int min, int max, int step)
    {
        return Kata.GenerateRange(min, max, step);
    }
}
