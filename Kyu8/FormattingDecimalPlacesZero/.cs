using System;

namespace Kyu8.FormattingDecimalPlaces;

public class Numbers
{
    public static double TwoDecimalPlaces(double number)
    {
        return Convert.ToDouble(number.ToString("0.00"));
    }
}


[TestFixture]
public class NumbersTest
{
    [Test, Order(1)]
    public void Test_01()
    {
        Assert.That(Numbers.TwoDecimalPlaces(4.659725356), Is.EqualTo(4.66));
    }

    [Test, Order(2)]
    public void Test_02()
    {
        Assert.That(Numbers.TwoDecimalPlaces(173735326.3783732637948948), Is.EqualTo(173735326.38));
    }
}
