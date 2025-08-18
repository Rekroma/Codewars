using System.Collections.Generic;

namespace Kyu7.NumberOfPeopleInTheBus;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        int people = 0;

        foreach (int[] ints in peopleListInOut)
        {
            people += ints[0];
            people -= ints[1];
        }

        return people;
    }
}


[TestFixture]
public class MyTest
{
    [Test, Order(1)]
    public void FirstTest()
    {
        List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
        Assert.That(Kata.Number(peopleList), Is.EqualTo(5));
    }

    [Test, Order(2)]
    public void SecondTest()
    {
        List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
        Assert.That(Kata.Number(peopleList), Is.EqualTo(17));
    }

    [Test, Order(3)]
    public void ThirdTest()
    {
        List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };
        Assert.That(Kata.Number(peopleList), Is.EqualTo(21));
    }
}