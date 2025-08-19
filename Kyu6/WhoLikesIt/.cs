namespace Kyu6.WhoLikesIt;

public static class Kata
{
    public static string Likes(string[] name)
    {
        return name.Length switch
        {
            0 => "no one likes this",
            1 => $"{name[0]} likes this",
            2 => $"{name[0]} and {name[1]} like this",
            3 => $"{name[0]}, {name[1]} and {name[2]} like this",
            > 3 => $"{name[0]}, {name[1]} and {name.Length - 2} others like this"
        };
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("It should return correct text")]
    public void SampleTest()
    {
        Assert.That(Kata.Likes(new string[0]), Is.EqualTo("no one likes this"));
        Assert.That(Kata.Likes(new string[] { "Peter" }), Is.EqualTo("Peter likes this"));
        Assert.That(Kata.Likes(new string[] { "Jacob", "Alex" }), Is.EqualTo("Jacob and Alex like this"));
        Assert.That(Kata.Likes(new string[] { "Max", "John", "Mark" }), Is.EqualTo("Max, John and Mark like this"));
        Assert.That(Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }), Is.EqualTo("Alex, Jacob and 2 others like this"));
    }
}