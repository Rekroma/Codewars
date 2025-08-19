namespace Kyu6.Persist;

public class Persist
{
    public static int Persistence(long n)
    {
        int count = 0;

        while (n >= 10)
        {
            long product = 1;

            while (n > 0)
            {
                product *= n % 10;
                n /= 10;
            }

            n = product;
            count++;
        }

        return count;
    }
}


[TestFixture]
public class PersistTests
{

    [Test]
    public void ExampleTests()
    {
        Assert.That(Persist.Persistence(39), Is.EqualTo(3));
        Assert.That(Persist.Persistence(4), Is.EqualTo(0));
        Assert.That(Persist.Persistence(25), Is.EqualTo(2));
        Assert.That(Persist.Persistence(999), Is.EqualTo(4));
    }
}