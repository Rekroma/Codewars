namespace Kyu8.ConvertToBooleanToAString;

public class kata
{
    public static string BooleanToString(bool b)
    {
        return b.ToString();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTests()
    {
        Assert.That(kata.BooleanToString(true), Is.EqualTo("True"));
        Assert.That(kata.BooleanToString(false), Is.EqualTo("False"));
    }
}