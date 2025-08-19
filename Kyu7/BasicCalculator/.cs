using System;

namespace Kyu7.BasicCalculator;

public static class Calculator
{
    public static double Execute(double num1, char op, double num2)
    {
        return op switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 == 0 ? throw new ArgumentException("Trying to divide by zero") : num1 / num2,
            _ => throw new ArgumentException("Invalid operator", nameof(op))
        };
    }

}


[TestFixture]
public class NumbersTest
{
    [Test, Order(1)]
    public void Test_01()
    {
        Assert.That(Calculator.Execute(3.2, '+', 8), Is.EqualTo(11.2));
    }

    [Test, Order(2)]
    public void Test_02()
    {
        Assert.That(Calculator.Execute(3.2, '-', 8), Is.EqualTo(-4.8));
    }

    [Test, Order(3)]
    public void Test_03()
    {
        Assert.That(Calculator.Execute(3.2, '/', 8), Is.EqualTo(0.4));
    }

    [Test, Order(4)]
    public void Test_04()
    {
        Assert.That(Calculator.Execute(3.2, '*', 8), Is.EqualTo(25.6));
    }

    [Test, Order(5)]
    public void Test_10()
    {
        Assert.Throws<ArgumentException>(() => Calculator.Execute(-3, 'w', 1));
    }
}
