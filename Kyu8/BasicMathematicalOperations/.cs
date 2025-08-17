namespace Kyu8.BasicMathematicalOperations;

public static class Program
{
    public static double basicOp(char operation, double value1, double value2)
    {
        switch (operation)
        {
            case '+': return value1 + value2;
            case '-': return value1 - value2;
            case '*': return value1 * value2;
            case '/': return value1 / value2;
        }

        return 0;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void StaticTests()
    {
        Assert.That(Program.basicOp('+', 4, 7), Is.EqualTo(11));
        Assert.That(Program.basicOp('-', 15, 18), Is.EqualTo(-3));
        Assert.That(Program.basicOp('*', 5, 5), Is.EqualTo(25));
        Assert.That(Program.basicOp('/', 49, 7), Is.EqualTo(7));
    }
}
