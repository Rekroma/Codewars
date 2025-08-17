namespace Kyu8BasicVariableAssignment;

public class Kata
{
    public static string A = "code";
    public static string B = "wa.rs";
    public static string Name = A + B;
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void Test()
    {
        Assert.That(Kata.Name, Is.EqualTo("codewa.rs"));
    }
}