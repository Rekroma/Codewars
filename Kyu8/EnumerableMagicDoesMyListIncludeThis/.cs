using System.Linq;

namespace Kyu8.EnumerableMagicDoesMyListIncludeThis;

public class Kata
{
    public static bool Include(int[] arr, int item)
    {
        return arr.Contains(item);
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Include(new int[] { 1, 2, 3, 4 }, 3), Is.True);
        Assert.That(Kata.Include(new int[] { 1, 2, 4, 5 }, 3), Is.False);
    }
}