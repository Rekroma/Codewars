namespace Kyu8.LeonardoDicaprioAndOscars;

public static class Kata
{
    public static string Leo(int oscar)
    {
        return oscar == 88 ? "Leo finally won the oscar! Leo is happy" : oscar == 86 ? "Not even for Wolf of wallstreet?!" : oscar > 88 ? "Leo got one already!" : "When will you give Leo an Oscar?";
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [TestCase(88, ExpectedResult = "Leo finally won the oscar! Leo is happy")]
    public string LeoTest(int oscar)
    {
        return Kata.Leo(oscar);
    }
}