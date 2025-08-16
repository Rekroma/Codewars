namespace Kyu8.FixmeReplaceAllDots;

public class Kata
{
    public static string ReplaceDots(string str)
    {
        return str.Replace(".", "-");
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.ReplaceDots("one.two.three"), Is.EqualTo("one-two-three"));
    }
}