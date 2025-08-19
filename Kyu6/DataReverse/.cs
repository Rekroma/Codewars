using System.Linq;

namespace Kyu6.DataReverse;

public class Kata
{
    public static int[] DataReverse(int[] data)
    {
        return Enumerable.Range(0, data.Length / 8).Select(i => data.Skip(i * 8).Take(8)).Reverse().SelectMany(chunk => chunk).ToArray();
    }
}


[TestFixture]
public static class Tests
{

    [Test, Order(1)]
    public static void test1()
    {
        int[] data1 = new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };
        int[] data2 = new int[32] { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
        Assert.That(Kata.DataReverse(data1), Is.EqualTo(data2));
    }

    [Test, Order(2)]
    public static void test2()
    {
        int[] data1 = new int[16] { 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1 };
        int[] data2 = new int[16] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0 };
        Assert.That(Kata.DataReverse(data1), Is.EqualTo(data2));
    }

}