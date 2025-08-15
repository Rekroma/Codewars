namespace Kyu8.Multiply;

public class SolutionClass
{
    public static string EvenOrOdd(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
}


[TestFixture]
public class ExampleTests
{
    [TestCase(1)]
    [TestCase(7)]
    public void PositiveOddTest(int number)
    {
        Assert.That(SolutionClass.EvenOrOdd(number), Is.EqualTo("Odd"), $"Incorrect answer for number={number}");
    }

    [TestCase(2)]
    [TestCase(42)]
    public void PositiveEvenTest(int number)
    {
        Assert.That(SolutionClass.EvenOrOdd(number), Is.EqualTo("Even"), $"Incorrect answer for number={number}");
    }

    [TestCase(-1)]
    [TestCase(-7)]
    public void NegativeOddTest(int number)
    {
        Assert.That(SolutionClass.EvenOrOdd(number), Is.EqualTo("Odd"), $"Incorrect answer for number={number}");
    }

    [TestCase(-2)]
    [TestCase(-42)]
    public void NegativeEvenTest(int number)
    {
        Assert.That(SolutionClass.EvenOrOdd(number), Is.EqualTo("Even"), $"Incorrect answer for number={number}");
    }

    [Test]
    public void ZeroIsEvenTest()
    {
        Assert.That(SolutionClass.EvenOrOdd(0), Is.EqualTo("Even"), "Incorrect answer for num=0");
    }
}