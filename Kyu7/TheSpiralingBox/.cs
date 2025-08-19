using System;

namespace Kyu7.TheSpiralingBox;

public class SpiralingBox
{
    public static int[,] CreateBox(int m, int n)
    {
        int[,] box = new int[n, m];
        int layerCount = Math.Min(m, n) / 2 + Math.Min(m, n) % 2;

        for (int layer = 0; layer < layerCount; layer++)
        {
            int value = layer + 1;

            for (int i = layer; i < m - layer; i++)
            {
                box[layer, i] = value;
                box[n - layer - 1, i] = value;
            }
            for (int j = layer; j < n - layer; j++)
            {
                box[j, layer] = value;
                box[j, m - layer - 1] = value;
            }
        }

        return box;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void sampleTests()
    {
        int[,] box_7_8 = {{1, 1, 1, 1, 1, 1, 1},
                          {1, 2, 2, 2, 2, 2, 1},
                          {1, 2, 3, 3, 3, 2, 1},
                          {1, 2, 3, 4, 3, 2, 1},
                          {1, 2, 3, 4, 3, 2, 1},
                          {1, 2, 3, 3, 3, 2, 1},
                          {1, 2, 2, 2, 2, 2, 1},
                          {1, 1, 1, 1, 1, 1, 1}};

        int[,] box_8_7 = {{1, 1, 1, 1, 1, 1, 1, 1},
                          {1, 2, 2, 2, 2, 2, 2, 1},
                          {1, 2, 3, 3, 3, 3, 2, 1},
                          {1, 2, 3, 4, 4, 3, 2, 1},
                          {1, 2, 3, 3, 3, 3, 2, 1},
                          {1, 2, 2, 2, 2, 2, 2, 1},
                          {1, 1, 1, 1, 1, 1, 1, 1}};

        int[,] box_4_2 = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };

        int[,] box_2_4 = { { 1, 1 }, { 1, 1 }, { 1, 1 }, { 1, 1 } };

        Assert.That(SpiralingBox.CreateBox(7, 8), Is.EqualTo(box_7_8));

        Assert.That(SpiralingBox.CreateBox(8, 7), Is.EqualTo(box_8_7));

        Assert.That(SpiralingBox.CreateBox(4, 2), Is.EqualTo(box_4_2));

        Assert.That(SpiralingBox.CreateBox(2, 4), Is.EqualTo(box_2_4));
    }
}