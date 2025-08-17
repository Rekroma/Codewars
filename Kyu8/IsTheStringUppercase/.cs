namespace Kyu8.IsTheStringUppercase;

public static class StringExtensions
{
    public static bool IsUpperCase(this string text)
    {
        return text == text.ToUpper();
    }
}


public class Tests
{
    [Test]
    [TestCase("c", ExpectedResult = false)]
    [TestCase("C", ExpectedResult = true)]
    [TestCase("hello I AM DONALD", ExpectedResult = false)]
    [TestCase("HELLO I AM DONALD", ExpectedResult = true)]
    [TestCase("ACSKLDFJSgSKLDFJSKLDFJ", ExpectedResult = false)]
    [TestCase("ACSKLDFJSGSKLDFJSKLDFJ", ExpectedResult = true)]
    public static bool FixedTest(string text)
    {
        return text.IsUpperCase();
    }
}