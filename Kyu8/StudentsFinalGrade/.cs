namespace Kyu8.StudentsFinalGrade;

public class Kata
{
    public static int FinalGrade(int exam, int projects)
    {
        if (exam > 90 || projects > 10) return 100;
        if (exam > 75 && projects >= 5) return 90;
        if (exam > 50 && projects >= 2) return 75;
        else return 0;
    }
}


[TestFixture]
public class Testing
{
    [Test]
    public void FinalGradeTest()
    {
        Assert.That(Kata.FinalGrade(100, 12), Is.EqualTo(100));
        Assert.That(Kata.FinalGrade(85, 5), Is.EqualTo(90));
    }
}