using System;
using System.Linq;

namespace Kyu7.InitializeMyName;

public class Kata
{
    public static string InitializeNames(string name)
    {
        string[] names = name.Split();

        for (int i = 0; i < names.Length; i++)
        {
            if (i != 0 && i != names.Length - 1)
                names[i] = names[i][0].ToString() + ".";
        }

        return new string(String.Join(" ", names));
    }
}


[TestFixture]
public class KataTests
{
    [Test, Description("Only first name")]
    public void OnlyFirstName()
    {
        Assert.That(Kata.InitializeNames("Dimitri"), Is.EqualTo("Dimitri"));
    }

    [Test, Description("No middle name")]
    public void NoMiddleName()
    {
        Assert.That(Kata.InitializeNames("Jack Ryan"), Is.EqualTo("Jack Ryan"));
    }

    [Test, Description("One middle name")]
    public void OneMiddleName()
    {
        Assert.That(Kata.InitializeNames("Lois Mary Lane"), Is.EqualTo("Lois M. Lane"));
    }

    [Test, Description("More middle names")]
    public void MoreMiddleNames()
    {
        Assert.That(Kata.InitializeNames("Alice Betty Catherine Davis"), Is.EqualTo("Alice B. C. Davis"));
    }
}