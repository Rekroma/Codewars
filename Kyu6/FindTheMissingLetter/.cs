using System;

namespace Kyu6.FindTheMissingLetter;

public class Kata
{
    public static char FindMissingLetter(char[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] + 1 != array[i + 1])
            {
                return (char)(array[i] + 1);
            }
        }

        return '0';
    }
}


public class KataTests
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(Kata.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }), Is.EqualTo('e'));
        Assert.That(Kata.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }), Is.EqualTo('P'));
    }
}