using System.Collections.Generic;

namespace Kyu7.HelpTheFarmerToCountRabbitsChickensAndCows;

class Kata
{
    public static Dictionary<string, int> get_animals_count(int legs_number, int heads_number, int horns_number)
    {
        var animals = new Dictionary<string, int>();

        animals["cows"] = horns_number / 2;
        heads_number -= animals["cows"];
        legs_number -= animals["cows"] * 4;
        animals["rabbits"] = (legs_number - 2 * heads_number) / 2;
        animals["chickens"] = heads_number - animals["rabbits"];

        return animals;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        var expected = new Dictionary<string, int>(){
        {"rabbits", 3},
        {"chickens", 5},
        {"cows", 3}
      };
        Assert.That(Kata.get_animals_count(34, 11, 6), Is.EqualTo(expected));

        expected = new Dictionary<string, int>(){
        {"rabbits", 30},
        {"chickens", 7},
        {"cows", 5}
      };
        Assert.That(Kata.get_animals_count(154, 42, 10), Is.EqualTo(expected));
    }
}
