namespace Kyu8.TemplateStrings;

public class Templates
{
    public static string TempleStrings(string obj, string feature)
    {
        return $"{obj} are {feature}";
    }
}


[TestFixture]
public class TemplatesTests
{
    [Test]
    public void TempleStrings()
    {
        Assert.That(Templates.TempleStrings("Animals", "Good"), Is.EqualTo("Animals are Good"));
    }
}