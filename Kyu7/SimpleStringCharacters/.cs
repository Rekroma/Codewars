using System;

namespace Kyu7.SimpleStringCharacters;

public class Solution
{
    public static int[] solve(String s)
    {
        int upper = 0;
        int lower = 0;
        int number = 0;
        int special = 0;

        foreach (char c in s)
        {
            if (char.IsUpper(c)) upper++;
            else if (char.IsLower(c)) lower++;
            else if (char.IsDigit(c)) number++;
            else special++;
        }

        return new int[] { upper, lower, number, special };
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(Solution.solve("Codewars@codewars123.com"), Is.EqualTo(new int[] { 1, 18, 3, 2 }));
        Assert.That(Solution.solve("bgA5<1d-tOwUZTS8yQ"), Is.EqualTo(new int[] { 7, 6, 3, 2 }));
        Assert.That(Solution.solve("P*K4%>mQUDaG$h=cx2?.Czt7!Zn16p@5H"), Is.EqualTo(new int[] { 9, 9, 6, 9 }));
        Assert.That(Solution.solve("RYT'>s&gO-.CM9AKeH?,5317tWGpS<*x2ukXZD"), Is.EqualTo(new int[] { 15, 8, 6, 9 }));
    }
}