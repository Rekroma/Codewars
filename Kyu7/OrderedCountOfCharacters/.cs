using System;
using System.Linq;
using System.Collections.Generic;

namespace Kyu7.OrderedCountOfCharacters;

public class Kata
{
    public static List<Tuple<char, int>> OrderedCount(string input)
    {
        var touples = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (touples.ContainsKey(c))
            {
                touples[c] += 1;
            }
            else
            {
                touples.Add(c, 1);
            }
        }

        return touples.Select(x => new Tuple<char, int>(x.Key, x.Value)).ToList();
    }
}


[TestFixture]
public class ExampleTestSuite
{
    [Test]
    public void ExampleTests()
    {
        var expected1 = new List<Tuple<char, int>>() {
                tuple('a', 5),
                tuple('b', 2),
                tuple('r', 2),
                tuple('c', 1),
                tuple('d', 1)
            };
        Assert.That(Kata.OrderedCount("abracadabra"), Is.EqualTo(expected1));

        var expected2 = new List<Tuple<char, int>>() {
                tuple('C', 1),
                tuple('o', 1),
                tuple('d', 1),
                tuple('e', 1),
                tuple(' ', 1),
                tuple('W', 1),
                tuple('a', 1),
                tuple('r', 1),
                tuple('s', 1)
            };
        Assert.That(Kata.OrderedCount("Code Wars"), Is.EqualTo(expected2));
    }

    private static Tuple<char, int> tuple(char character, int count)
    {
        return new Tuple<char, int>(character, count);
    }
}
