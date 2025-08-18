using System;
using System.Linq;
using System.Collections.Generic;

namespace Kyu5.DirectionsReduction;

public class DirReduction
{
    public static string[] dirReduc(string[] arr)
    {
        Stack<string> directions = new Stack<string>();

        Dictionary<string, string> opposite = new Dictionary<string, string>()
        {
            {"NORTH", "SOUTH"},
            {"SOUTH", "NORTH"},
            {"EAST", "WEST"},
            {"WEST", "EAST"}
        };

        foreach (string direction in arr)
        {
            if (directions.Count > 0 && directions.Peek() == opposite[direction])
            {
                directions.Pop();
            }
            else
            {
                directions.Push(direction);
            }
        }

        return directions.Reverse().ToArray();
    }
}


[TestFixture]
public class DirReductionTests
{

    [Test]
    [Order(1)]
    public void Test1()
    {
        string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
        string[] b = new string[] { "WEST" };
        Assert.That(DirReduction.dirReduc(a), Is.EqualTo(b));
    }
    [Test]
    [Order(2)]
    public void Test2()
    {
        string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        Assert.That(DirReduction.dirReduc(a), Is.EqualTo(b));
    }
}