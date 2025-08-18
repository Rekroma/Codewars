using System.Collections.Generic;

namespace Kyu6.DeleteOccurrencesOfAnElementIfItOccursMoreThanNTimes;

public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (!count.ContainsKey(num))
                count[num] = 0;

            if (count[num] < x)
            {
                result.Add(num);
                count[num]++;
            }
        }

        return result.ToArray();
    }
}


[TestFixture]
public class DeleteNthTests
{
    [Test]
    [Order(1)]
    public void TestSimple()
    {
        var expected = new int[] { 20, 37, 21 };

        var actual = Kata.DeleteNth(new int[] { 20, 37, 20, 21 }, 1);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [Order(2)]
    public void TestSimple2()
    {
        var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

        var actual = Kata.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

        Assert.That(actual, Is.EqualTo(expected));
    }
}