using System.Linq;

namespace Kyu7.adenCasingStrings;

public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        return string.Join(" ", phrase.Split(' ').Select(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
    }
}


[TestFixture]
public class JadenCaseTest
{
    [Test]
    public void FixedTest()
    {
        Assert.That("How can mirrors be real if our eyes aren't real".ToJadenCase(),
                    Is.EqualTo("How Can Mirrors Be Real If Our Eyes Aren't Real"),
                    "Strings didn't match.");
    }
}