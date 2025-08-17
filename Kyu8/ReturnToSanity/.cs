using System.Collections.Generic;

namespace Kyu8.ReturnToSanity;

public class Kata
{
    public static Dictionary<string, string> Mystery()
    {
        Dictionary<string, string> results = new Dictionary<string, string>();
        results.Add("sanity", "hello");
        return results;
    }
}


[TestFixture]
public class Return_To_Sanity
{
    [Test]
    public void Is_It_Sane()
    {
        var sanity = new Dictionary<string, string> { { "sanity", "hello" } };
        Assert.That(Kata.Mystery(), Is.EqualTo(sanity), "Mystery has not returned to sanity.");
    }
}