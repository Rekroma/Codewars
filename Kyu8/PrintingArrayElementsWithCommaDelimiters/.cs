using System;
using System.Linq;

namespace kyu8.PrintingArrayElementsWithCommaDelimiters;

public class Kata
{
    public static string PrintArray(object[] array)
    {
        return string.Join(',', array.Select(o => o is Array ? PrintArray((object[])o) : o));
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        var data = new object[] { 2, 4, 5, 2 };
        Assert.That(Kata.PrintArray(data), Is.EqualTo("2,4,5,2"), "int test failed");
    }
}