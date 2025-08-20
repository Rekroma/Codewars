using System.Linq;

namespace Kyu7.ReturnTheMissingElement;

public static class Kata
{
    public static int GetMissingElement(int[] superImportantArray)
    {
        return 45 - superImportantArray.Sum();
    }
}


[TestFixture]
public class MissingElement
{
    [Test, Order(1)]
    public void EightIsMissing()
    {
        Assert.That(Kata.GetMissingElement(new int[9] { 0, 5, 1, 3, 2, 9, 7, 6, 4 }), Is.EqualTo(8));
    }

    [Test, Order(2)]
    public void ThreeIsMissing()
    {
        Assert.That(Kata.GetMissingElement(new int[9] { 9, 2, 4, 5, 7, 0, 8, 6, 1 }), Is.EqualTo(3));
    }
}