using System.Linq;

namespace Kyu8.GetTheMeanOfAnArray;

public class Kata
{
    public static int GetAverage(int[] marks)
    {
        return (int)marks.Average();
    }
}


public class Tests
{
    [Test]
    [TestCase(new int[] { 2, 2, 2, 2 }, ExpectedResult = 2)]
    [TestCase(new int[] { 5, 10 }, ExpectedResult = 7)]
    public static int FixedTest(int[] marks)
    {
        return Kata.GetAverage(marks);
    }
}