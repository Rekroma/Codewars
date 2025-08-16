using System;

namespace Kyu8.SimpleCalculator;

public class Kata
{
    public static double Calculator(double a, double b, char op)
    {
        switch (op)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                if (b == 0)
                {
                    throw new ArgumentException("Cannot divide by zero.");
                }
                return a / b;
            default:
                throw new ArgumentException("Invalid operator.");
        }
    }
}


[TestFixture]
public class CalculatorTest
{
    [Test, Description("should calculate the result of valid inputs"), Order(1)]
    public void Test()
    {
        Assert.That(Kata.Calculator(6, 2, '+'), Is.EqualTo(8));
        Assert.That(Kata.Calculator(4, 3, '-'), Is.EqualTo(1));
        Assert.That(Kata.Calculator(5, 5, '*'), Is.EqualTo(25));
        Assert.That(Kata.Calculator(5, 4, '/'), Is.EqualTo(1.25));
    }

    [Test, Description("should throw ArgumentException with invalid inputs"), Order(2)]
    public void ErrorTest()
    {
        Assert.That(() => Kata.Calculator(6, 2, '&'), Throws.ArgumentException);
    }
}