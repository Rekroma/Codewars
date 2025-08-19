using System;
using System.Linq;

namespace Kyu6.SupermarketQueue;

public class Kata
{
    public static long QueueTime(int[] customers, int n)
    {
        long[] tills = new long[n];

        foreach (int customer in customers)
        {
            int index = Array.IndexOf(tills, tills.Min());
            tills[index] += customer;
        }

        return tills.Max();
    }
}


[TestFixture]
public class Tests
{
    [Test, Order(1)]
    public void ExampleTest1()
    {
        long expected = 0;

        long actual = Kata.QueueTime(new int[] { }, 1);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public void ExampleTest2()
    {
        long expected = 10;

        long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4 }, 1);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(3)]
    public void ExampleTest3()
    {
        long expected = 9;

        long actual = Kata.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(4)]
    public void ExampleTest4()
    {
        long expected = 5;

        long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100);

        Assert.That(actual, Is.EqualTo(expected));
    }
}