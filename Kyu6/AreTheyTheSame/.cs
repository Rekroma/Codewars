using System.Linq;

namespace Kyu6.AreTheyTheSame;

class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        if (a == null && b == null) return true;
        if (a == null || b == null) return false;
        a = a.OrderBy(a => a).Select(x => x * x).ToArray();
        b = b.OrderBy(b => b).ToArray();
        return a.SequenceEqual(b);
    }
}


[TestFixture]
public class AreTheySameTests
{

    [Test]
    public void Test1()
    {
        int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
        int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
        bool r = AreTheySame.comp(a, b);
        Assert.That(r, Is.True);
    }
}