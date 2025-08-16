using System.Linq;

namespace Kyu8.AllStarCodeChallengeOneEight;

class Kata
{
    public static int StrCount(string str, char letter)
    {
        return str.Where(c => c == letter).Count();
    }

}


[TestFixture]
class Test
{
    [TestCase("Hello", 'o', 1)]
    [TestCase("Hello", 'l', 2)]
    [TestCase("Hello", 'p', 0)]
    [TestCase("", 'z', 0)]
    public void BasicTests(string str, char letter, int expected)
    {
        Assert.That(Kata.StrCount(str, letter), Is.EqualTo(expected));
    }
}