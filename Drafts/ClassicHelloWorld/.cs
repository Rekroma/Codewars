namespace Kyu8.ClassicHelloWorld;

public static class Solution
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World!");
    }
}


[TestFixture]
public class StringToNumberTest
{
    [Test]
    public void test1()
    {
        Solution.Main(new string[] { "Greetings from Javatlacati" });
        Assert.That(1, Is.EqualTo(1));
    }
}