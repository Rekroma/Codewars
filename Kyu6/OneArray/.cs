using System;
using System.Linq;

namespace Kyu6.OneArray;

public static class Kata
{
    public static int[] UpArray(int[] num)
    {
        if (num == null || num.Length == 0) return null;
        if (num.Any(n => n < 0 || n > 9)) return null;
        int carry = 1;

        for (int i = num.Length - 1; i >= 0; i--)
        {
            num[i] += carry;
            if (num[i] == 10)
            {
                num[i] = 0;
                carry = 1;
            }
            else
            {
                carry = 0; break;
            }
        }
        if (carry == 1)
        {
            int[] result = new int[num.Length + 1];
            result[0] = 1;
            Array.Copy(num, 0, result, 1, num.Length);
            return result;
        }

        return num;
    }
}


[TestFixture]
public class ArrayTest
{
    [Test, Order(1)]
    public void Test1()
    {
        var num = new int[] { 2, 3, 9 };
        var newNum = new int[] { 2, 4, 0 };
        Assert.That(Kata.UpArray(num), Is.EqualTo(newNum));
    }

    [Test, Order(2)]
    public void Test2()
    {
        var num = new int[] { 4, 3, 2, 5 };
        var newNum = new int[] { 4, 3, 2, 6 };
        Assert.That(Kata.UpArray(num), Is.EqualTo(newNum));
    }

    [Test, Order(3)]
    public void Test3()
    {
        var num = new int[] { 0, 4, 2 };
        var newNum = new int[] { 0, 4, 3 };
        Assert.That(Kata.UpArray(num), Is.EqualTo(newNum));
    }

    [Test, Order(4)]
    public void Test4()
    {
        var num = new int[] { 9, 9 };
        var newNum = new int[] { 1, 0, 0 };
        Assert.That(Kata.UpArray(num), Is.EqualTo(newNum));
    }

    [Test, Order(5)]
    public void UpBigArray()
    {
        var num = new int[] { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 1 };
        var newNum = new int[] { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 2 };
        Assert.That(Kata.UpArray(num), Is.EqualTo(newNum));
    }
}