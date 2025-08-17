namespace Kyu8.TransportationOnVacation;

public class RentalCar
{
    public static int RentalCarCost(int d)
    {
        return d >= 7 ? d * 40 - 50 : d >= 3 ? d * 40 - 20 : d * 40;
    }
}


[TestFixture]
public static class RentalCarTests
{
    private static void testing(int actual, int expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public static void test1()
    {
        testing(RentalCar.RentalCarCost(1), 40);
        testing(RentalCar.RentalCarCost(3), 100);
        testing(RentalCar.RentalCarCost(7), 230);
    }
}