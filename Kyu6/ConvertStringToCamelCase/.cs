using System;

namespace Kyu6.ConvertStringToCamelCase;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        string res = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '-' || str[i] == '_')
            {
                res += char.ToUpper(str[i + 1]);
                i++;
            }
            else
            {
                res += str[i];
            }

        }

        return res;
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void KataTests()
    {
        Assert.That(Kata.ToCamelCase("the_stealth_warrior"), Is.EqualTo("theStealthWarrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
        Assert.That(Kata.ToCamelCase("The-Stealth-Warrior"), Is.EqualTo("TheStealthWarrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
    }
}