namespace Kyu8.ClassyClasses;

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string Info => $"{name}s age is {age}";

    public string GetInfo()
    {
        return $"{name}s age is {age}";
    }
}


[TestFixture]
public class Person_Class_Test
{
    [Test, Description("Should create a Person and have a getter for the Info property")]
    public void Test()
    {
        Person john = new Person("john", 34);
        string expectedInfo = "johns age is 34";
        Assert.That(john.Info, Is.EqualTo(expectedInfo));
    }
}