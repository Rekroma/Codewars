using System.Collections.Generic;

namespace Kyu5.OnesZerosAndWildcards;

public class Kata
{
    public List<string> Possibilities(string input)
    {
        List<string> result = new List<string>();
        GenerateCombinations(input.ToCharArray(), 0, result);
        return result;
    }

    private void GenerateCombinations(char[] chars, int index, List<string> result)
    {
        if (index == chars.Length)
        {
            result.Add(new string(chars));
            return;
        }
        if (chars[index] == '?')
        {
            chars[index] = '0';
            GenerateCombinations(chars, index + 1, result);
            chars[index] = '1';
            GenerateCombinations(chars, index + 1, result);
            chars[index] = '?';
        }
        else
        {
            GenerateCombinations(chars, index + 1, result);
        }
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void Basic1()
    {
        var list = new System.Collections.Generic.List<string> { "1001", "1011" };
        var result = new Kata().Possibilities("10?1").OrderBy(t => t);
        Assert.That(result, Is.EqualTo(list.OrderBy(t => t)));
    }

    [Test, Order(2)]
    public void Basic2()
    {
        var list = new System.Collections.Generic.List<string> { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
        var result = new Kata().Possibilities("????").OrderBy(t => t);
        Assert.That(result, Is.EqualTo(list.OrderBy(t => t)));
    }
}