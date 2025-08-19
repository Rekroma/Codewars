using System.Collections.Generic;

namespace Kyu6.RomanNumeralsDecoder;

public class RomanDecode
{
    public static int Solution(string roman)
    {
        var map = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        int total = 0;

        for (int i = 0; i < roman.Length; i++)
        {
            int current = map[roman[i]];

            if (i + 1 < roman.Length && map[roman[i + 1]] > current)
            {
                total -= current;
            }
            else
            {
                total += current;
            }
        }

        return total;
    }
}


[TestFixture]
public class RomanDecodeTests
{
    [TestCase(1, "I")]
    public void Test(int expected, string roman)
    {
        Assert.That(RomanDecode.Solution(roman), Is.EqualTo(expected));
    }
}