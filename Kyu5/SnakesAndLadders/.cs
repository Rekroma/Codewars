using System.Collections.Generic;

namespace Kyu5.SnakesAndLadders;

public class SnakesLadders
{
    private int[] pos = new[] { 0, 0 };
    private int player = 0;
    private bool gameOver = false;

    private Dictionary<int, int> events = new Dictionary<int, int>
        {
            { 2, 38 }, { 7, 14 }, { 8, 31 }, { 15, 26 }, { 16, 6 },
            { 21, 42 }, { 28, 84 }, { 36, 44 }, { 46, 25 }, { 49, 11 },
            { 51, 67 }, { 62, 19 }, { 64, 60 }, { 71, 91 }, { 74, 53 },
            { 78, 98 }, { 87, 94 }, { 89, 68 }, { 92, 88 }, { 95, 75 },
            { 99, 80 }
        };

    public string play(int die1, int die2)
    {
        if (gameOver) return "Game over!";

        int move = die1 + die2;
        int next = pos[player] + move;

        if (next > 100) next = 100 - (next - 100);
        if (events.ContainsKey(next)) next = events[next];

        pos[player] = next;

        if (next == 100)
        {
            gameOver = true;
            return $"Player {player + 1} Wins!";
        }
        string result = $"Player {player + 1} is on square {pos[player]}";
        if (die1 != die2) player = 1 - player;

        return result;
    }
}


class Tests
{
    [Test]
    public void SampleTests()
    {
        SnakesLadders snakeLadders = new SnakesLadders();

        string roll1 = snakeLadders.play(1, 1);
        Assert.That(roll1, Is.EqualTo("Player 1 is on square 38"));
        string roll2 = snakeLadders.play(1, 5);
        Assert.That(roll2, Is.EqualTo("Player 1 is on square 44"));
        string roll3 = snakeLadders.play(6, 2);
        Assert.That(roll3, Is.EqualTo("Player 2 is on square 31"));
        string roll4 = snakeLadders.play(1, 1);
        Assert.That(roll4, Is.EqualTo("Player 1 is on square 25"));
    }
}