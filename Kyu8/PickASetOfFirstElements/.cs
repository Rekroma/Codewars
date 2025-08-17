using System.Linq;

namespace Kyu8.PickASetOfFirstElements;

public class Kata
{
    public static object[] TakeFirstElements(object[] array, int n = 1)
    {
        return n == 0 ? new object[0] : array.Take(n > array.Length ? array.Length : n).ToArray();
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void BasicTests()
    {
        var arr = new object[] { 'a', 'b', 'c', 'd', 'e' };
        Assert.That(Kata.TakeFirstElements(arr), Is.EqualTo(new object[] { 'a' }));
        Assert.That(Kata.TakeFirstElements(arr, 2), Is.EqualTo(new object[] { 'a', 'b' }));
    }
}