namespace Kyu7.SubstitutingVariablesIntoStringsPaddedNumbers;

public class PaddedNumbers
{
    public static string Solution(int value)
    {
        return $"Value is {value.ToString("00000")}";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(PaddedNumbers.Solution(5), Is.EqualTo("Value is 00005"));
    }
}