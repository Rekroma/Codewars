using System;
using System.Linq;

namespace Kyu7.FindAllOccurrencesOfAnElementInAnArray;

public class Kata
{
    public static int[] FindAll(int[] array, int n)
    {
        int[] result = new int[array.Count(x => x == n)];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == n)
            {
                result[index] = i;
                index++;
            }
        }

        return result;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Your solution should pass some fixed tests")]
    public void FixedTest()
    {
        Assert.That(Kata.FindAll(new int[] { 6, 9, 3, 4, 3, 82, 11 }, 3), Is.EqualTo(new int[] { 2, 4 }));
        Assert.That(Kata.FindAll(new int[] { 10, 16, 20, 6, 14, 11, 20, 2, 17, 16, 14 }, 16), Is.EqualTo(new int[] { 1, 9 }));
        Assert.That(Kata.FindAll(new int[] { 20, 20, 10, 13, 15, 2, 7, 2, 20, 3, 18, 2, 3, 2, 16, 10, 9, 9, 7, 5, 15, 5 }, 20), Is.EqualTo(new int[] { 0, 1, 8 }));
    }
}