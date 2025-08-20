namespace Kyu7.RotateForAMax;

public class MaxRotate
{
    public static long MaxRot(long n)
    {
        string s = n.ToString();
        long max = n;

        for (int i = 0; i < s.Length - 1; i++)
        {
            string fixedPart = s.Substring(0, i);
            string rotatingPart = s.Substring(i);

            rotatingPart = rotatingPart.Substring(1) + rotatingPart[0];

            s = fixedPart + rotatingPart;

            long rotated = long.Parse(s);
            if (rotated > max)
                max = rotated;
        }

        return max;
    }
}


[TestFixture]
public static class MaxRotateTests
{
    [Test]
    public static void TestSamples()
    {
        Assert.That(MaxRotate.MaxRot(38458215), Is.EqualTo(85821534), "For n = 38458215");
        Assert.That(MaxRotate.MaxRot(195881031), Is.EqualTo(988103115), "For n = 195881031");
        Assert.That(MaxRotate.MaxRot(896219342), Is.EqualTo(962193428), "For n = 896219342");
        Assert.That(MaxRotate.MaxRot(69418307), Is.EqualTo(94183076), "For n = 69418307");
    }
}