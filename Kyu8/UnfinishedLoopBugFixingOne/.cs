using System.Collections.Generic;

namespace Kyu8.UnfinishedLoopBugFixingOne;

public class Kata
{
    public static List<int> CreateList(int number)
    {
        List<int> list = new List<int>();

        for (int counter = 1; counter <= number; counter++)
        {
            list.Add(counter);
        }

        return list;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public static void FixedTest()
    {
        List<int> myValues = new List<int>(new int[] { 1 });
        Assert.That(Kata.CreateList(1), Is.EqualTo(myValues));

        myValues = new List<int>(new int[] { 1, 2 });
        Assert.That(Kata.CreateList(2), Is.EqualTo(myValues));

        myValues = new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
        Assert.That(Kata.CreateList(6), Is.EqualTo(myValues));
    }
}