using System;

namespace Kyu6.MazeRunner;

class Kata
{
    public string mazeRunner(int[,] maze, string[] directions)
    {
        (int, int) position = (-1, -1);

        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                if (maze[i, j] == 2)
                {
                    position = (i, j);
                    break;
                }
            }
            if (position != (-1, -1)) break;
        }

        if (position == (-1, -1)) return "Dead";

        foreach (var dir in directions)
        {
            switch (dir)
            {
                case "N": position = (position.Item1 - 1, position.Item2); break;
                case "S": position = (position.Item1 + 1, position.Item2); break;
                case "W": position = (position.Item1, position.Item2 - 1); break;
                case "E": position = (position.Item1, position.Item2 + 1); break;
            }

            if (position.Item1 < 0 || position.Item1 >= maze.GetLength(0) || position.Item2 < 0 || position.Item2 >= maze.GetLength(1)) return "Dead";
            if (maze[position.Item1, position.Item2] == 1) return "Dead";
            if (maze[position.Item1, position.Item2] == 3) return "Finish";
        }

        return "Lost";
    }
}


[TestFixture]
class KataTestClass
{
    private int[,] maze = new int[,] { { 1, 1, 1, 1, 1, 1, 1 },
                                       { 1, 0, 0, 0, 0, 0, 3 },
                                       { 1, 0, 1, 0, 1, 0, 1 },
                                       { 0, 0, 1, 0, 0, 0, 1 },
                                       { 1, 0, 1, 0, 1, 0, 1 },
                                       { 1, 0, 0, 0, 0, 0, 1 },
                                       { 1, 2, 1, 0, 1, 0, 1 } };

    [TestCase, Order(1)]
    public void FinishTest1()
    {
        string[] directions = new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E", "E" };
        Kata test = new Kata();
        string result = test.mazeRunner(maze, directions);
        Assert.That(result, Is.EqualTo("Finish"), "Should return: 'Finish'");
    }

    [TestCase, Order(2)]
    public void FinishTest2()
    {
        string[] directions = new string[] { "N", "N", "N", "N", "N", "E", "E", "S", "S", "E", "E", "N", "N", "E" };
        Kata test = new Kata();
        string result = test.mazeRunner(maze, directions);
        Assert.That(result, Is.EqualTo("Finish"), "Should return: 'Finish'");
    }

    [TestCase, Order(3)]
    public void FinishTest3()
    {
        string[] directions = new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E", "E", "W", "W" };
        Kata test = new Kata();
        string result = test.mazeRunner(maze, directions);
        Assert.That(result, Is.EqualTo("Finish"), "Should return: 'Finish'");
    }

    [TestCase, Order(4)]
    public void DeadTest1()
    {
        string[] directions = new string[] { "N", "N", "N", "W", "W" };
        Kata test = new Kata();
        string result = test.mazeRunner(maze, directions);
        Assert.That(result, Is.EqualTo("Dead"), "Should return: 'Dead'");
    }

    [TestCase, Order(5)]
    public void DeadTest2()
    {
        string[] directions = new string[] { "N", "N", "N", "N", "N", "E", "E", "S", "S", "S", "S", "S", "S" };
        Kata test = new Kata();
        string result = test.mazeRunner(maze, directions);
        Assert.That(result, Is.EqualTo("Dead"), "Should return: 'Dead'");
    }

    [TestCase, Order(6)]
    public void LostTest1()
    {
        string[] directions = new string[] { "N", "E", "E", "E", "E" };
        Kata test = new Kata();
        string result = test.mazeRunner(maze, directions);
        Assert.That(result, Is.EqualTo("Lost"), "Should return: 'Lost'");
    }

}