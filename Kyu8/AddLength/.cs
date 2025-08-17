using System.Linq;

namespace Kyu8.AddLength;

public class Kata
{
    public static string[] AddLength(string str)
    {
        return str.Split(' ').Select(s => s + " " + s.Length).ToArray();
    }
}


[TestFixture]
public class Sample_Test
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.AddLength("apple ban"), Is.EqualTo(new string[] { "apple 5", "ban 3" }));
        Assert.That(Kata.AddLength("you will win"), Is.EqualTo(new string[] { "you 3", "will 4", "win 3" }));
    }
}