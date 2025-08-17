namespace Kyu8.GrasshopperBasicFunctionFixer;

public class Kata
{
    public static int AddFive(int num)
    {
        return num + 5;
    }
}


[TestFixture]
public class Tests
{
    [TestCase(5, ExpectedResult = 10)]
    [TestCase(0, ExpectedResult = 5)]
    [TestCase(-5, ExpectedResult = 0)]
    public static int FixedTest(int num)
    {
        return Kata.AddFive(num);
    }
}
