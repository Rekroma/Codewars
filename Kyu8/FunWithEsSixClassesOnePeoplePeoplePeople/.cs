namespace Kyu8.FunWithEsSixClassesOnePeoplePeoplePeople;

public class Person
{
    public Person(string firstName = "John", string lastName = "Doe", int age = 0, string gender = "Male")
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Gender = gender;
    }
    public string SayFullName() => $"{FirstName} {LastName}".TrimEnd();
    public static string GreetExtraTerrestrials(string raceName) => $"Welcome to Planet Earth {raceName}";
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public string Gender { get; private set; }
}


[TestFixture]
public class SampleTest
{
    [Test, Description("should have the correct defaults"), Order(1)]
    public void DefaultArgsTest()
    {
        Person person = new Person();
        Assert.That(person.FirstName, Is.EqualTo("John"));
        Assert.That(person.LastName, Is.EqualTo("Doe"));
        Assert.That(person.Age, Is.EqualTo(0));
        Assert.That(person.Gender, Is.EqualTo("Male"));
        Assert.That(person.SayFullName(), Is.EqualTo("John Doe"));
    }

    [Test, Description("should work with a person Jane Doe"), Order(2)]
    public void CustomTest()
    {
        Person person = new Person("Jane", "Doe", 25, "Female");
        Assert.That(person.FirstName, Is.EqualTo("Jane"));
        Assert.That(person.LastName, Is.EqualTo("Doe"));
        Assert.That(person.Age, Is.EqualTo(25));
        Assert.That(person.Gender, Is.EqualTo("Female"));
        Assert.That(person.SayFullName(), Is.EqualTo("Jane Doe"));
    }
}