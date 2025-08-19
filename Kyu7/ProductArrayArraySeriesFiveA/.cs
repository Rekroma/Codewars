using System.Linq;

namespace Kyu7.ProductArrayArraySeriesFiveA;

class Kata
{
    public static int[] ProductArray(int[] array)
    {
        int[] arr = new int[array.Length];
        int SafeNum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            SafeNum = array[i];
            array[i] = 1;
            arr[i] = array.Take(array.Length).Aggregate((a, b) => a * b);
            array[i] = SafeNum;
        }

        return arr;
    }
}


[TestFixture]
class Tests
{
    [TestCase("12 20", "20 12")]
    [TestCase("3 27 4 2", "216 24 162 324")]
    [TestCase("13 10 5 2 9", "900 1170 2340 5850 1300")]
    [TestCase("16 17 4 3 5 2", "2040 1920 8160 10880 6528 16320")]
    public void BasicTest(string s, string str)
    {
        Assert.That(Kata.ProductArray(Foo(s)), Is.EqualTo(Foo(str)));
    }
    int[] Foo(string s) => s.Split().Select(int.Parse).ToArray();
}