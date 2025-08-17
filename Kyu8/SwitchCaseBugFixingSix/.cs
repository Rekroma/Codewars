using System;

namespace Kyu8.SwitchCaseBugFixingSix;

public class Kata
{
    public static double EvalObject(double value1, double value2, char operation)
    {
        double result = 0;
        switch (operation)
        {
            case '+': result = value1 + value2; break;
            case '-': result = value1 - value2; break;
            case '/': result = value1 / value2; break;
            case '*': result = value1 * value2; break;
            case '%': result = value1 % value2; break;
            case '^': result = Math.Pow(value1, value2); break;
        }
        return result;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public static void FixedTest()
    {
        Assert.That(Kata.EvalObject(1, 1, '+'), Is.EqualTo(2));
        Assert.That(Kata.EvalObject(1, 1, '-'), Is.EqualTo(0));
        Assert.That(Kata.EvalObject(1, 1, '/'), Is.EqualTo(1));
        Assert.That(Kata.EvalObject(1, 1, '*'), Is.EqualTo(1));
        Assert.That(Kata.EvalObject(1, 1, '%'), Is.EqualTo(0));
        Assert.That(Kata.EvalObject(1, 1, '^'), Is.EqualTo(1));
    }
}