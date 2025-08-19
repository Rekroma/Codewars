using System;
using System.Linq;
using System.Collections.Generic;

namespace Betadrafts.AdditiveColors;

public class AddColors
{
    public static string AdditiveColors(string input)
    {
        var colorSet = input.Split(',')
                            .Select(c => c.Trim())
                            .Select(c => c.ToLower()) // Normalize case
                            .ToHashSet();

        if (colorSet.SetEquals(new HashSet<string> { "blue" })) return "Blue";
        if (colorSet.SetEquals(new HashSet<string> { "green" })) return "Green";
        if (colorSet.SetEquals(new HashSet<string> { "red" })) return "Red";
        if (colorSet.SetEquals(new HashSet<string> { "blue", "green" })) return "Cyan";
        if (colorSet.SetEquals(new HashSet<string> { "green", "red" })) return "Yellow";
        if (colorSet.SetEquals(new HashSet<string> { "red", "blue" })) return "Magenta";
        if (colorSet.SetEquals(new HashSet<string> { "blue", "green", "red" })) return "White";

        return "Invalid input"; // Handle unexpected input
    }

    public static void Main()
    {
        Console.WriteLine(AdditiveColors("Blue, Green")); // Output: Cyan
        Console.WriteLine(AdditiveColors("Green, Red"));  // Output: Yellow
        Console.WriteLine(AdditiveColors("Red, Blue"));   // Output: Magenta
        Console.WriteLine(AdditiveColors("Blue, Green, Red")); // Output: White
        Console.WriteLine(AdditiveColors("Blue")); // Output: Blue
        Console.WriteLine(AdditiveColors("blue, red")); // Output: Magenta (case insensitive)
        Console.WriteLine(AdditiveColors("yellow")); // Output: Invalid input
    }
}


[TestFixture]
public class AdditiveTests
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(AddColors.AdditiveColors("Green"), Is.EqualTo("Green"));
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(AddColors.AdditiveColors("Red,Green"), Is.EqualTo("Yellow"));
    }
}