using System.Collections.Generic;

namespace Kyu6.FixmeHello;

public class Dinglemouse
{
    string name;
    int age;
    char sex;
    Dictionary<string, object> changeLogs = new();
    string str = "Hello. ";

    public Dinglemouse()
    {
    }

    public Dinglemouse SetAge(int age)
    {
        this.age = age;
        if (changeLogs.ContainsKey("age"))
        {
            changeLogs["age"] = $"I am {age}.";
        }
        else
        {
            changeLogs.Add("age", $"I am {age}.");
        }
        return this;
    }

    public Dinglemouse SetSex(char sex)
    {
        this.sex = sex;
        if (changeLogs.ContainsKey("sex"))
        {
            changeLogs["sex"] = $"I am {(sex == 'F' ? "female" : "male")}.";
        }
        else
        {
            changeLogs.Add("sex", $"I am {(sex == 'F' ? "female" : "male")}.");
        }
        return this;
    }

    public Dinglemouse SetName(string name)
    {
        this.name = name;
        if (changeLogs.ContainsKey("name"))
        {
            changeLogs["name"] = $"My name is {name}.";
        }
        else
        {
            changeLogs.Add("name", $"My name is {name}.");
        }
        return this;
    }

    public string Hello()
    {
        foreach (KeyValuePair<string, object> entry in changeLogs)
        {
            switch (entry.Key)
            {
                case "name":
                    str += changeLogs["name"] + " ";
                    break;
                case "age":
                    str += changeLogs["age"] + " ";
                    break;
                case "sex":
                    str += changeLogs["sex"] + " ";
                    break;
            }
        }

        return str.TrimEnd(' ');
    }
}


public class ExampleTests
{
    [Test, Order(1)]
    public void TestBob27Male()
    {
        var dm = new Dinglemouse().SetName("Bob").SetAge(27).SetSex('M');
        var expected = "Hello. My name is Bob. I am 27. I am male.";
        Assert.That(dm.Hello(), Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public void Test27MaleBob()
    {
        var dm = new Dinglemouse().SetAge(27).SetSex('M').SetName("Bob");
        var expected = "Hello. I am 27. I am male. My name is Bob.";
        Assert.That(dm.Hello(), Is.EqualTo(expected));
    }

    [Test, Order(3)]
    public void TestAliceFemale()
    {
        var dm = new Dinglemouse().SetName("Alice").SetSex('F');
        var expected = "Hello. My name is Alice. I am female.";
        Assert.That(dm.Hello(), Is.EqualTo(expected));
    }

    [Test, Order(4)]
    public void TestBatman()
    {
        var dm = new Dinglemouse().SetName("Batman");
        var expected = "Hello. My name is Batman.";
        Assert.That(dm.Hello(), Is.EqualTo(expected));
    }
}