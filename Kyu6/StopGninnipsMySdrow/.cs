using System.Linq;

namespace Kyu6.StopGninnipsMySdrow;

public class Kata
{
    public static string SpinWords(string sentence)
    {

        string str = "";

        foreach (string s in sentence.Split())
        {
            if (s.Length >= 5)
            {
                str += new string(s.Reverse().ToArray()) + " ";
            }
            else str += s + " ";
        }

        return str.TrimEnd();
    }
}


[TestFixture]
public class Tests
{
    [Test, Order(1)]
    public static void Test1()
    {
        var expected = "emocleW";
        Assert.That(Kata.SpinWords("Welcome"), Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public static void Test2()
    {
        var expected = "Hey wollef sroirraw";
        Assert.That(Kata.SpinWords("Hey fellow warriors"), Is.EqualTo(expected));
    }

    [Test, Order(3)]
    public static void Test3()
    {
        var expected = "This is a test";
        Assert.That(Kata.SpinWords("This is a test"), Is.EqualTo(expected));
    }

    [Test, Order(4)]
    public static void Test4()
    {
        var expected = "This is rehtona test";
        Assert.That(Kata.SpinWords("This is another test"), Is.EqualTo(expected));
    }

    [Test, Order(5)]
    public static void Test5()
    {
        var expected = "You are tsomla to the last test";
        Assert.That(Kata.SpinWords("You are almost to the last test"), Is.EqualTo(expected));
    }

    [Test, Order(6)]
    public static void Test6()
    {
        var expected = "Just gniddik ereht is llits one more";
        Assert.That(Kata.SpinWords("Just kidding there is still one more"), Is.EqualTo(expected));
    }
}