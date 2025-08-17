namespace Kyu8.FindTheSlope;

public class Slope
{

    public string slope(int[] points)
    {
        return points[2] == points[0] ? "undefined" : ((points[3] - points[1]) / (points[2] - points[0])).ToString();
    }

}


[TestFixture]
public class SlopeTest
{
    [Test]
    public void test1()
    {
        int[] test1 = { 19, 3, 20, 3 };
        int[] test2 = { 7, 2, 7, 4 };
        int[] test3 = { 10, 50, 30, 150 };
        int[] test4 = { 15, 45, 12, 60 };
        int[] test5 = { 10, 20, 20, 80 };
        int[] test6 = { -10, 6, -10, 3 };
        Slope s = new Slope();
        Assert.That(s.slope(test1), Is.EqualTo("0"));
        Assert.That(s.slope(test2), Is.EqualTo("undefined"));
        Assert.That(s.slope(test3), Is.EqualTo("5"));
        Assert.That(s.slope(test4), Is.EqualTo("-5"));
        Assert.That(s.slope(test5), Is.EqualTo("6"));
        Assert.That(s.slope(test6), Is.EqualTo("undefined"));
    }
}