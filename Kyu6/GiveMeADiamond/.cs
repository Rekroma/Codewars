using System.Text;

namespace Kyu6.GiveMeADiamond;

public class Diamond
{
    public static string print(int n)
    {
        if (n < 0 || n % 2 == 0) return null;

        string res = "";

        for (int i = 0; i < n; i++)
        {
            int stars = i <= n / 2 ? (2 * i + 1) : (2 * (n - i - 1) + 1);
            int spaces = (n - stars) / 2;

            res += new string(' ', spaces) + new string('*', stars) + "\n";
        }

        return res;
    }
}


[TestFixture]
public class DiamondTest
{
    [Test, Order(1)]
    public void TestNull()
    {
        Assert.That(Diamond.print(0), Is.Null);
        Assert.That(Diamond.print(-2), Is.Null);
        Assert.That(Diamond.print(2), Is.Null);
    }

    [Test, Order(2)]
    public void TestDiamond1()
    {
        var expected = new StringBuilder();
        expected.Append("*\n");
        Assert.That(Diamond.print(1), Is.EqualTo(expected.ToString()));
    }

    [Test, Order(3)]
    public void TestDiamond3()
    {
        var expected = new StringBuilder();
        expected.Append(" *\n");
        expected.Append("***\n");
        expected.Append(" *\n");

        Assert.That(Diamond.print(3), Is.EqualTo(expected.ToString()));
    }

    [Test, Order(4)]
    public void TestDiamond5()
    {
        var expected = new StringBuilder();
        expected.Append("  *\n");
        expected.Append(" ***\n");
        expected.Append("*****\n");
        expected.Append(" ***\n");
        expected.Append("  *\n");

        Assert.That(Diamond.print(5), Is.EqualTo(expected.ToString()));
    }
}
