namespace Kyu8.SimpleFunOneSeatsInTheater;

public class Kata
{
    public static int SeatsInTheater(int nCols, int nRows, int col, int row)
    {
        return (nRows - row) * (nCols - col + 1);
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(Kata.SeatsInTheater(16, 11, 5, 3), Is.EqualTo(96));

        Assert.That(Kata.SeatsInTheater(1, 1, 1, 1), Is.EqualTo(0));

        Assert.That(Kata.SeatsInTheater(13, 6, 8, 3), Is.EqualTo(18));

        Assert.That(Kata.SeatsInTheater(60, 100, 60, 1), Is.EqualTo(99));

        Assert.That(Kata.SeatsInTheater(1000, 1000, 1000, 1000), Is.EqualTo(0));
    }
}