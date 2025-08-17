namespace Kyu8.BasicSubclassesAdamAndEve; 
public class God
{
    public static Human[] Create()
    {
        return new Human[] { new Man(), new Woman() };
    }
}
public class Human { }

public class Man : Human { }

public class Woman : Human { }


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Human[] humans = God.Create();
        Assert.That(humans[0], Is.InstanceOf<Man>(), "The first object in the array should be a Man");
    }
}