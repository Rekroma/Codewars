namespace Kyu8.AB;

public class FirstClass
{
    public static byte sum(byte a, byte b)
    {
        return (byte)(a + b);
    }
}


[TestFixture]
public class FirstClassTest
{
    [Test]
    public void testSum()
    {
        byte a = 1;
        byte b = 2;
        Assert.That(FirstClass.sum(a, b), Is.EqualTo(3));
    }
}