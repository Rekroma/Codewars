namespace Kyu8.CalculateBmi;

public class Kata
{
    public static string Bmi(double weight, double height)
    {
        double bmi = weight / (height * height);
        if (bmi <= 18.5)
        {
            return "Underweight";
        }
        else if (bmi <= 25)
        {
            return "Normal";
        }
        else if (bmi <= 30)
        {
            return "Overweight";
        }
        else return "Obese";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Bmi(50, 1.80), Is.EqualTo("Underweight"), "For weight = 50 and height = 1.80");
        Assert.That(Kata.Bmi(80, 1.80), Is.EqualTo("Normal"), "For weight = 80 and height = 1.80");
        Assert.That(Kata.Bmi(90, 1.80), Is.EqualTo("Overweight"), "For weight = 90 and height = 1.80");
        Assert.That(Kata.Bmi(100, 1.80), Is.EqualTo("Obese"), "For weight = 100 and height = 1.80");
    }
}