namespace Kyu7.CheckTheExam;

public static class Kata
{
    public static int CheckExam(string[] arr1, string[] arr2)
    {
        int score = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] == arr2[i]) score += 4;
            else if (arr2[i] == "") continue;
            else score -= 1;
        }

        return score >= 0 ? score : 0;
    }
}


[TestFixture]
public class KataTests
{
    [TestCase(new string[] { "a", "a", "b", "b" }, new string[] { "a", "c", "b", "d" }, 6)]
    [TestCase(new string[] { "a", "a", "c", "b" }, new string[] { "a", "a", "b", "" }, 7)]
    [TestCase(new string[] { "a", "a", "b", "c" }, new string[] { "a", "a", "b", "c" }, 16)]
    [TestCase(new string[] { "b", "c", "b", "a" }, new string[] { "", "a", "a", "c" }, 0)]
    public void SampleTest(string[] arr1, string[] arr2, int score)
    {
        Assert.That(Kata.CheckExam(arr1, arr2), Is.EqualTo(score));
    }
}
