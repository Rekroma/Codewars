using System.Collections.Generic;

namespace Kyu7.TurnAnyWordIntoABeefTaco;

public class Kata
{
    public static string[] Tacofy(string word)
    {
        var ingredients = new List<string>();
        word = word.ToLower();
        ingredients.Add("shell");

        foreach (char c in word)
        {
            if ("aeiou".Contains(c)) ingredients.Add("beef");
            else if (c == 't') ingredients.Add("tomato");
            else if (c == 'l') ingredients.Add("lettuce");
            else if (c == 'c') ingredients.Add("cheese");
            else if (c == 'g') ingredients.Add("guacamole");
            else if (c == 's') ingredients.Add("salsa");
        }
        ingredients.Add("shell");

        return ingredients.ToArray();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.Tacofy(""), Is.EqualTo(new string[] { "shell", "shell" }));
        Assert.That(Kata.Tacofy("a"), Is.EqualTo(new string[] { "shell", "beef", "shell" }));
        Assert.That(Kata.Tacofy("ggg"), Is.EqualTo(new string[] { "shell", "guacamole", "guacamole", "guacamole", "shell" }));
        Assert.That(Kata.Tacofy("ogl"), Is.EqualTo(new string[] { "shell", "beef", "guacamole", "lettuce", "shell" }));
        Assert.That(Kata.Tacofy("ydjkpwqrzto"), Is.EqualTo(new string[] { "shell", "tomato", "beef", "shell" }));
    }
}