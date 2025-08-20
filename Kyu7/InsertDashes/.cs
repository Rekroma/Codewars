namespace Kyu7.InsertDashes;

public class Kata
{
    public static string InsertDash(int num)
    {
        string numStr = num.ToString();
        string result = "";

        for (int i = 0; i < numStr.Length - 1; i++)
        {
            result += numStr[i];
            if ((numStr[i] - '0') % 2 != 0 && (numStr[i + 1] - '0') % 2 != 0) result += "-";
        }

        return result + numStr[^1];
    }

}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.InsertDash(454793), Is.EqualTo("4547-9-3"));
        Assert.That(Kata.InsertDash(123456), Is.EqualTo("123456"));
        Assert.That(Kata.InsertDash(1003567), Is.EqualTo("1003-567"));
    }
}