namespace Kyu7.SmallEnoughBeginner;

public class Kata
{
    public static bool SmallEnough(int[] a, int limit)
    {
        foreach (int i in a)
        {
            if (i > limit)
            {
                return false;
            }
        }

        return true;
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.SmallEnough(new int[] { 66, 101 }, 200), Is.True);
        Assert.That(Kata.SmallEnough(new int[] { 78, 117, 110, 99, 104, 117, 107, 115 }, 100), Is.False);
        Assert.That(Kata.SmallEnough(new int[] { 101, 45, 75, 105, 99, 107 }, 107), Is.True);
        Assert.That(Kata.SmallEnough(new int[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 120), Is.True);
    }
}