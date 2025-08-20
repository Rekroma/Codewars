namespace Kyu7.HowManyArguments;

public static class Kata
{
    public static int CountArgs(params object[] o)
    {
        return o.Length;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.CountArgs(1, 2, 3), Is.EqualTo(3));
        Assert.That(Kata.CountArgs(1, 2, "uhsaf uas"), Is.EqualTo(3));
        Assert.That(Kata.CountArgs(1), Is.EqualTo(1));
        Assert.That(Kata.CountArgs('a', 865, "asfhgajsf", new object[] { "dawdjio", null, new List<object>() }), Is.EqualTo(4));
        Assert.That(Kata.CountArgs(), Is.EqualTo(0));
    }
}