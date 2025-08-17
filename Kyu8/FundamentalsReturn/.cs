using System;

namespace Kyu8.FundamentalsReturn;

public static class Kata
{
    public static int Add(int a, int b) => a + b;
    public static int Mod(int a, int b) => a % b;
    public static int Subt(int a, int b) => a - b;
    public static int Divide(int a, int b) => a / b;
    public static int Multiply(int a, int b) => a * b;
    public static int Exponent(int a, int b) => (int)Math.Pow(a, b);
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void BasicTestAddition()
    {
        Assert.That(Kata.Add(5, 7), Is.EqualTo(12),
          "Addition for 5 added to 7 should be: 12");
    }

    [Test, Order(2)]
    public void BasicTestMultiplication()
    {
        Assert.That(Kata.Multiply(5, 2), Is.EqualTo(10),
          "Multiplication for 5 multiplied by 2 should be: 10");
    }
}