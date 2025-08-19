using System;

namespace Kyu5.WhatsAPerfectPowerAnyway;

public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        for (int i = 2; i * i <= n; i++)
        {
            int p = (int)(Math.Log(n) / Math.Log(i) + 0.5);

            if (Math.Pow(i, p) == n)
            {
                return (i, p);
            }
        }

        return null;
    }
}


public class PerfectPowerTest
{
    [Test, Order(1)]
    public void Test0()
    {
        Assert.That(PerfectPower.IsPerfectPower(0), Is.Null, "0 is not a perfect number");
    }

    [Test, Order(2)]
    public void Test1()
    {
        Assert.That(PerfectPower.IsPerfectPower(1), Is.Null, "1 is not a perfect number");
    }

    [Test, Order(3)]
    public void Test2()
    {
        Assert.That(PerfectPower.IsPerfectPower(2), Is.Null, "2 is not a perfect number");
    }

    [Test, Order(4)]
    public void Test3()
    {
        Assert.That(PerfectPower.IsPerfectPower(3), Is.Null, "3 is not a perfect number");
    }

    [Test, Order(5)]
    public void Test4()
    {
        Assert.That(PerfectPower.IsPerfectPower(4), Is.EqualTo((2, 2)), "4 = 2^2");
    }

    [Test, Order(6)]
    public void Test5()
    {
        Assert.That(PerfectPower.IsPerfectPower(5), Is.Null, "5 is not a perfect power");
    }

    [Test, Order(7)]
    public void Test8()
    {
        Assert.That(PerfectPower.IsPerfectPower(8), Is.EqualTo((2, 3)), "8 = 2^3");
    }

    [Test, Order(8)]
    public void Test9()
    {
        Assert.That(PerfectPower.IsPerfectPower(9), Is.EqualTo((3, 2)), "9 = 3^2");
    }

    [Test, Order(9)]
    public void TestUpTo500()
    {
        var pp = new int[] { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
        foreach (var i in pp)
            Assert.That(PerfectPower.IsPerfectPower(i), Is.Not.Null, $"{i} is a perfect power");
    }
}