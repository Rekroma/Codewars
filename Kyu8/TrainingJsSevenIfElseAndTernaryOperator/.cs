namespace Kyu8.TrainingJsSevenIfElseAndTernaryOperator;

public class Kata
{
    public static int SaleHotDogs(int n)
    {
        return n < 5 ? 100 * n : n < 10 ? 95 * n : 90 * n;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.SaleHotDogs(1), Is.EqualTo(100));
        Assert.That(Kata.SaleHotDogs(4), Is.EqualTo(400));
        Assert.That(Kata.SaleHotDogs(5), Is.EqualTo(475));
        Assert.That(Kata.SaleHotDogs(9), Is.EqualTo(855));
        Assert.That(Kata.SaleHotDogs(10), Is.EqualTo(900));
        Assert.That(Kata.SaleHotDogs(100), Is.EqualTo(9000));
    }
}