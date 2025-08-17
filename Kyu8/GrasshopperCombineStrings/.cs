namespace Kyu8.GrasshopperCombineStrings;

public class Kata
{
    public static string CombineNames(string a, string b)
    {
        return a + " " + b;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [TestCase("James", "Stevens", ExpectedResult = "James Stevens")]
    public static string FixedTest(string a, string b)
    {
        return Kata.CombineNames(a, b);
    }
}