namespace Kyu8.GetNthEvenNumber;

public class Kata
{
    public static int NthEven(int n)
    {
        return (n - 1) * 2;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    [TestCase(1, ExpectedResult = 0)]
    [TestCase(3, ExpectedResult = 4)]
    [TestCase(100, ExpectedResult = 198)]
    [TestCase(1298734, ExpectedResult = 2597466)]
    public int FixedTest(int n)
    {
        return Kata.NthEven(n);
    }
}