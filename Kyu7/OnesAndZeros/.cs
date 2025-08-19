using System;
using System.Linq;

namespace Kyu7.OnesAndZeros;

class Kata
{
    public static int binaryArrayToNumber(int[] binaryArray)
    {
        int num = 0;

        foreach (var bit in binaryArray)
        {
            num = (num << 1) | bit;
        }

        return num;
    }
}


[TestFixture]
public class SolutionTest
{
    int[] Test1 = new int[] { 0, 0, 0, 0 };
    int[] Test2 = new int[] { 1, 1, 1, 1 };
    int[] Test3 = new int[] { 0, 1, 1, 0 };
    int[] Test4 = new int[] { 0, 1, 0, 1 };
    [Test]
    public void BasicTesting()
    {
        Assert.That(Kata.binaryArrayToNumber(Test1), Is.EqualTo(0));
        Assert.That(Kata.binaryArrayToNumber(Test2), Is.EqualTo(15));
        Assert.That(Kata.binaryArrayToNumber(Test3), Is.EqualTo(6));
        Assert.That(Kata.binaryArrayToNumber(Test4), Is.EqualTo(5));
    }
}
