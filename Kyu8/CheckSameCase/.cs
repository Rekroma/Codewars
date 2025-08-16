namespace Kyu8.CheckSameCase;

public class Kata
{
    public static int SameCase(char a, char b)
    {
        return !char.IsLetter(a) || !char.IsLetter(b) ? -1 : char.IsUpper(a) == char.IsLower(b) ? 0 : 1;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void TrueTests()
    {
        Assert.That(Kata.SameCase('a', 'u'), Is.EqualTo(1));
        Assert.That(Kata.SameCase('A', 'U'), Is.EqualTo(1));
        Assert.That(Kata.SameCase('Q', 'P'), Is.EqualTo(1));
        Assert.That(Kata.SameCase('w', 'y'), Is.EqualTo(1));
        Assert.That(Kata.SameCase('c', 'm'), Is.EqualTo(1));
        Assert.That(Kata.SameCase('N', 'W'), Is.EqualTo(1));
    }
    [Test, Order(2)]
    public void FalseTests()
    {
        Assert.That(Kata.SameCase('a', 'U'), Is.EqualTo(0));
        Assert.That(Kata.SameCase('A', 'u'), Is.EqualTo(0));
        Assert.That(Kata.SameCase('Q', 'p'), Is.EqualTo(0));
        Assert.That(Kata.SameCase('w', 'Y'), Is.EqualTo(0));
        Assert.That(Kata.SameCase('c', 'M'), Is.EqualTo(0));
        Assert.That(Kata.SameCase('N', 'w'), Is.EqualTo(0));
    }
    [Test, Order(3)]
    public void NotLetters()
    {
        Assert.That(Kata.SameCase('a', '*'), Is.EqualTo(-1));
        Assert.That(Kata.SameCase('A', '%'), Is.EqualTo(-1));
        Assert.That(Kata.SameCase('Q', '1'), Is.EqualTo(-1));
        Assert.That(Kata.SameCase('w', '-'), Is.EqualTo(-1));
        Assert.That(Kata.SameCase('c', '8'), Is.EqualTo(-1));
        Assert.That(Kata.SameCase('N', ':'), Is.EqualTo(-1));
    }
}