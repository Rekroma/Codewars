using System;
using System.Linq;

namespace Kyu7.CurryingFunctionsMultiplyingAllElementsInAnArray;

public class Kata
{
    public static Func<int, int[]> MultiplyAll(int[] numbers)
    {
        return multiplier => numbers.Select(n => n * multiplier).ToArray();
    }
}


[TestFixture]
public class Currying
{
    [Test, Description("must return an array")]
    [Order(1)]
    public void ArrayTest()
    {
        Assert.That(Kata.MultiplyAll(new int[] { 1 })(1).GetType().IsArray, Is.True);
    }

    [Test, Description("array has correct length")]
    [Order(2)]
    public void LengthTest()
    {
        Assert.That(Kata.MultiplyAll(new int[] { 1, 2 })(1).Length, Is.EqualTo(2));
    }

    [Test, Description("returned array has correct values")]
    [Order(3)]
    public void ValuesTest()
    {
        Assert.That(Kata.MultiplyAll(new int[] { 1, 2, 3 })(1), Is.EqualTo(new int[] { 1, 2, 3 }));
        Assert.That(Kata.MultiplyAll(new int[] { 1, 2, 3 })(2), Is.EqualTo(new int[] { 2, 4, 6 }));
        Assert.That(Kata.MultiplyAll(new int[] { 1, 2, 3 })(0), Is.EqualTo(new int[] { 0, 0, 0 }));
        Assert.That(Kata.MultiplyAll(new int[] { })(10), Is.EqualTo(new int[] { }), "should return an empty array");
    }
}