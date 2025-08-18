using System.Linq;

namespace Kyu7.SumOfTwoLowestPositiveIntegers;

public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        numbers = numbers.OrderBy(x => x).ToArray();
        return numbers[0] + numbers[1];
    }
}


[TestFixture]
public class ConverterTests
{
    [Test, Order(1)]
    public void Test1()
    {
        int[] numbers = { 5, 8, 12, 19, 22 };
        Assert.That(Kata.sumTwoSmallestNumbers(numbers), Is.EqualTo(13));
    }

    [Test, Order(2)]
    public void Test2()
    {
        int[] numbers = { 19, 5, 42, 2, 77 };
        Assert.That(Kata.sumTwoSmallestNumbers(numbers), Is.EqualTo(7));
    }

    [Test, Order(3)]
    public void Test3()
    {
        int[] numbers = { 10, 343445353, 3453445, 2147483647 };
        Assert.That(Kata.sumTwoSmallestNumbers(numbers), Is.EqualTo(3453455));
    }
}