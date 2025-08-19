using System;

namespace Betadrafts.OneNineTwoFiveOneThreeThree;

public class SillyMath
{
    public static int SillyMultiply(int num1, int num2)
    {
        int sum = 0;
        string num = num2.ToString();

        for (int i = 0; i < num.Length; i++)
        {
            sum += (num[i] - '0') * num1;
        }

        return sum;
    }
}


[TestFixture]
public class SillyMathTest
{
    [Test, Order(1)]
    public void TitleMultiplication()
    {
        Assert.That(SillyMath.SillyMultiply(19, 25), Is.EqualTo(133));
    }

    [Test, Order(2)]
    public void MoreSillyMultiplication()
    {
        Assert.That(SillyMath.SillyMultiply(69, 131), Is.EqualTo(345));
        Assert.That(SillyMath.SillyMultiply(70, 31), Is.EqualTo(280));
        Assert.That(SillyMath.SillyMultiply(91, 42), Is.EqualTo(546));
        Assert.That(SillyMath.SillyMultiply(116, 182), Is.EqualTo(1276));
        Assert.That(SillyMath.SillyMultiply(125, 44), Is.EqualTo(1000));
    }

    [Test, Order(3)]
    public void RealMultiplication()
    {
        Assert.That(SillyMath.SillyMultiply(2, 2), Is.EqualTo(4));
        Assert.That(SillyMath.SillyMultiply(2, 3), Is.EqualTo(6));
        Assert.That(SillyMath.SillyMultiply(0, 0), Is.EqualTo(0));
        Assert.That(SillyMath.SillyMultiply(3, 3), Is.EqualTo(9));
    }

    [Test, Order(4)]
    public void OrderNotImportant()
    {
        Assert.That(SillyMath.SillyMultiply(336, 112), Is.EqualTo(SillyMath.SillyMultiply(112, 336)));
        Assert.That(SillyMath.SillyMultiply(13, 39), Is.EqualTo(SillyMath.SillyMultiply(39, 13)));
        Assert.That(SillyMath.SillyMultiply(88, 55), Is.EqualTo(SillyMath.SillyMultiply(55, 88)));
        Assert.That(SillyMath.SillyMultiply(366, 488), Is.EqualTo(SillyMath.SillyMultiply(488, 366)));
    }
}