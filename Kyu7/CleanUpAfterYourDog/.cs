namespace Kyu7.CleanUpAfterYourDog;

public class Kata
{
    public static string Crap(char[,] x, int bags, int cap)
    {
        int crap = 0;

        for (int i = 0; i < x.GetLength(0); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
            {
                if (x[i, j] == '@')
                {
                    crap++;
                }
                if (x[i, j] == 'D')
                {
                    return "Dog!!";
                }
            }
        }
        if (crap > bags * cap)
        {
            return "Cr@p";
        }

        return "Clean";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Crap(new char[,] { { '_', '_', '_', '_' }, { '_', '_', '_', '@' }, { '_', '_', '@', '_' } }, 2, 2), Is.EqualTo("Clean"));
        Assert.That(Kata.Crap(new char[,] { { '_', '_', '_', '_' }, { '_', '_', '_', '@' }, { '_', '_', '@', '_' } }, 1, 1), Is.EqualTo("Cr@p"));
        Assert.That(Kata.Crap(new char[,] { { '_', '_' }, { '_', '@' }, { 'D', '_' } }, 2, 2), Is.EqualTo("Dog!!"));
    }
}