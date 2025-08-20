using System.Collections.Generic;
using System.Linq;

namespace Kyu6.UniqueInOrder;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {

        if (!iterable.Any()) return iterable;
        var list = new List<T>();
        list.Add(iterable.First());

        for (int i = 1; i < iterable.LongCount(); i++)
        {
            if (iterable.ElementAt(i - 1).Equals(iterable.ElementAt(i))) continue;
            else list.Add(iterable.ElementAt(i));
        }

        return list.AsEnumerable();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    [Order(1)]
    public void EmptyTest()
    {
        Assert.That(Kata.UniqueInOrder(""), Is.EqualTo(""));
    }
    [Test]
    [Order(2)]
    public void Test1()
    {
        Assert.That(Kata.UniqueInOrder("AAAABBBCCDAABBB"), Is.EqualTo("ABCDAB"));
    }
}