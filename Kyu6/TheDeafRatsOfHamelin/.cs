namespace Kyu6.TheDeafRatsOfHamelin;

public class Dinglemouse
{
    public static int CountDeafRats(string town)
    {
        string s1 = town.Split('P')[0].Replace(" ", "");
        string s2 = town.Split('P')[1].Replace(" ", "");
        int deafRats = 0;

        for (int i = 0; i < s1.Length - 1; i++)
        {
            if (s1.Substring(i, 2) == "O~") deafRats++; i++;
        }
        for (int i = 0; i < s2.Length - 1; i++)
        {
            if (s2.Substring(i, 2) == "~O") deafRats++; i++;
        }

        return deafRats;
    }
}


[TestFixture]
public class SolutionTest
{
    private static object[] Basic_Test_Cases = new object[]
    {
      new object[] {"~O~O~O~O P", 0},
      new object[] {"P O~ O~ ~O O~", 1},
      new object[] {"~O~O~O~OP~O~OO~", 2},
    };

    [Test, TestCaseSource(typeof(SolutionTest), "Basic_Test_Cases"), Order(1)]
    public void Basic_Test(string town, int expected)
    {
        Assert.That(Dinglemouse.CountDeafRats(town), Is.EqualTo(expected));
    }
}