using System;

namespace Kyu8.BasicMakingSixToast;

public class Kata
{
    public static int SixToast(int num)
    {
        return Math.Abs(6 - num);
    }
}


[TestFixture]
public class SampleTest
{
    [Test]
    public void Test()
    {
        Assert.That(Kata.SixToast(6), Is.EqualTo(0));
        Assert.That(Kata.SixToast(17), Is.EqualTo(11));
        Assert.That(Kata.SixToast(3), Is.EqualTo(3));
    }
}