using System.Collections.Generic;

namespace Kyu8.Welcome;

public static class Kata
{
    public static string Greet(string language)
    {
        var dictionary = new Dictionary<string, string>
           {
               { "english", "Welcome" },
               { "czech", "Vitejte" },
               { "danish", "Velkomst" },
               { "dutch", "Welkom" },
               { "estonian", "Tere tulemast" },
               { "finnish", "Tervetuloa" },
               { "flemish", "Welgekomen" },
               { "french", "Bienvenue" },
               { "german", "Willkommen" },
               { "irish", "Failte" },
               { "italian", "Benvenuto" },
               { "latvian", "Gaidits" },
               { "lithuanian", "Laukiamas" },
               { "polish", "Witamy" },
               { "spanish", "Bienvenido" },
               { "swedish", "Valkommen" },
               { "welsh", "Croeso" }
          };

        return dictionary.ContainsKey(language) ? dictionary[language] : "Welcome";
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.Greet("english"), Is.EqualTo("Welcome"));
        Assert.That(Kata.Greet("dutch"), Is.EqualTo("Welkom"));
        Assert.That(Kata.Greet("IP_ADDRESS_INVALID"), Is.EqualTo("Welcome"));
        Assert.That(Kata.Greet(""), Is.EqualTo("Welcome"));
        Assert.That(Kata.Greet("2"), Is.EqualTo("Welcome"));
    }
}
