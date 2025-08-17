using System;

namespace Kyu8.ConvertAStringToANumber;

public class Kata
{
    public static int StringToNumber(String str)
    {
        return Convert.ToInt32(str);
    }
}


[TestFixture]
public class StringToNumberTest
{
    [Test, Order(1)]
    public void test1()
    {
        Assert.That(Kata.StringToNumber("1234"), Is.EqualTo(1234));
    }

    [Test, Order(2)]
    public void test2()
    {
        Assert.That(Kata.StringToNumber("605"), Is.EqualTo(605));
    }

    [Test, Order(3)]
    public void test3()
    {
        Assert.That(Kata.StringToNumber("1405"), Is.EqualTo(1405));
    }

    [Test, Order(4)]
    public void test4()
    {
        Assert.That(Kata.StringToNumber("-7"), Is.EqualTo(-7));
    }
}