namespace Kyu7.FunWithEsSixClassesTwoAnimalsAndInheritance;

public class Shark : Animal
{
    public Shark(string name, int age, string status)
        : base(name, age, 0, "shark", status)
    {
    }
}

public class Cat : Animal
{
    public Cat(string name, int age, string status)
        : base(name, age, 4, "cat", status)
    {
    }

    public override string Introduce()
    {
        return base.Introduce() + "  Meow meow!";
    }
}

public class Dog : Animal
{
    private string master;

    public Dog(string name, int age, string status, string master)
        : base(name, age, 4, "dog", status)
    {
        this.master = master;
    }

    public string GreetMaster()
    {
        return $"Hello {master}";
    }
}


[TestFixture, Order(1)]
public class SharkTest
{
    [Test, Description("should construct an object properly")]
    public void ConstructorTest()
    {
        Shark billy = new Shark("Billy", 3, "Alive and well");
        Assert.That(billy.Name, Is.EqualTo("Billy"));
        Assert.That(billy.Age, Is.EqualTo(3));
        Assert.That(billy.Legs, Is.EqualTo(0));
        Assert.That(billy.Species, Is.EqualTo("shark"));
        Assert.That(billy.Status, Is.EqualTo("Alive and well"));
        Assert.That(billy.Introduce(), Is.EqualTo("Hello, my name is Billy and I am 3 years old."));
        Shark charles = new Shark("Charles", 8, "Looking for a mate");
        Assert.That(charles.Name, Is.EqualTo("Charles"));
        Assert.That(charles.Age, Is.EqualTo(8));
        Assert.That(charles.Legs, Is.EqualTo(0));
        Assert.That(charles.Species, Is.EqualTo("shark"));
        Assert.That(charles.Status, Is.EqualTo("Looking for a mate"));
        Assert.That(charles.Introduce(), Is.EqualTo("Hello, my name is Charles and I am 8 years old."));
    }
}

[TestFixture, Order(2)]
public class CatTest
{
    [Test, Description("should construct an object properly")]
    public void ConstructorTest()
    {
        Cat cathy = new Cat("Cathy", 7, "Playing with a ball of yarn");
        Assert.That(cathy.Name, Is.EqualTo("Cathy"));
        Assert.That(cathy.Age, Is.EqualTo(7));
        Assert.That(cathy.Legs, Is.EqualTo(4));
        Assert.That(cathy.Species, Is.EqualTo("cat"));
        Assert.That(cathy.Status, Is.EqualTo("Playing with a ball of yarn"));
        Assert.That(cathy.Introduce(), Is.EqualTo("Hello, my name is Cathy and I am 7 years old.  Meow meow!"));
        Cat spitsy = new Cat("Spitsy", 6, "sleeping");
        Assert.That(spitsy.Name, Is.EqualTo("Spitsy"));
        Assert.That(spitsy.Age, Is.EqualTo(6));
        Assert.That(spitsy.Legs, Is.EqualTo(4));
        Assert.That(spitsy.Species, Is.EqualTo("cat"));
        Assert.That(spitsy.Status, Is.EqualTo("sleeping"));
        Assert.That(spitsy.Introduce(), Is.EqualTo("Hello, my name is Spitsy and I am 6 years old.  Meow meow!"));
    }
}

[TestFixture, Order(3)]
public class DogTest
{
    [Test, Description("should construct an object properly")]
    public void ConstructorTest()
    {
        Dog doug = new Dog("Doug", 12, "Serving his master", "Eliza");
        Assert.That(doug.Name, Is.EqualTo("Doug"));
        Assert.That(doug.Age, Is.EqualTo(12));
        Assert.That(doug.Legs, Is.EqualTo(4));
        Assert.That(doug.Species, Is.EqualTo("dog"));
        Assert.That(doug.Status, Is.EqualTo("Serving his master"));
        Assert.That(doug.GreetMaster(), Is.EqualTo("Hello Eliza"));
    }
}



public class Animal
{
    public string Name { get; }
    public int Age { get; }
    public int Legs { get; }
    public string Species { get; }
    public string Status { get; }

    public Animal(string name, int age, int legs, string species, string status)
    {
        Name = name;
        Age = age;
        Legs = legs;
        Species = species;
        Status = status;
    }

    public virtual string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old.";
    }
}

