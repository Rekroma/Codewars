using System.Linq;

namespace Kyu8.YouOnlyNeedOneBeginner;

public class Kata
{
    public static bool Check(object[] a, object x)
    {
        return a.Any(c => a.Contains(x));
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Check(new object[] { 66, 101 }, 66), Is.True);
        Assert.That(Kata.Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45), Is.True);

        Assert.That(Kata.Check(new object[] { 't', 'e', 's', 't' }, 'e'), Is.True);
        Assert.That(Kata.Check(new object[] { "what", "a", "great", "kata" }, "kat"), Is.False);
    }
}