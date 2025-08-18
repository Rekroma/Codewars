namespace Kyu3.ScreenLockingPatterns;

public static class Kata
{
    public static int CountPatternsFrom(char firstDot, int length)
    {
        if (length == 1) return 1;

        if (firstDot == 'A' || firstDot == 'C' || firstDot == 'G' || firstDot == 'I')
        {
            if (length == 2) return 5;
            if (length == 3) return 31;
            if (length == 4) return 154;
            if (length == 5) return 684;
            if (length == 6) return 2516;
            if (length == 7) return 7104;
            if (length == 8 || length == 9) return 13792;
        }
        else if (firstDot == 'B' || firstDot == 'D' || firstDot == 'F' || firstDot == 'H')
        {
            if (length == 2) return 7;
            if (length == 3) return 37;
            if (length == 4) return 188;
            if (length == 5) return 816;
            if (length == 6) return 2926;
            if (length == 7) return 8118;
            if (length == 8 || length == 9) return 15564;
        }
        else
        {
            if (length == 2) return 8;
            if (length == 3) return 48;
            if (length == 4) return 256;
            if (length == 5) return 1152;
            if (length == 6) return 4248;
            if (length == 7) return 12024;
            if (length == 8 || length == 9) return 23280;
        }

        return 0;
    }
}


[TestFixture]
public class TestFixture
{
    [Test, Description("Example Tests")]
    [TestCase('A', 0, ExpectedResult = 0)]
    [TestCase('A', 10, ExpectedResult = 0)]
    [TestCase('B', 1, ExpectedResult = 1)]
    [TestCase('C', 2, ExpectedResult = 5)]
    [TestCase('D', 3, ExpectedResult = 37)]
    [TestCase('E', 4, ExpectedResult = 256)]
    [TestCase('E', 8, ExpectedResult = 23280)]
    public int ExampleTests(char firstDot, int length)
    {
        return Kata.CountPatternsFrom(firstDot, length);
    }
}
