namespace Kyu8.GrashopperTerminalGameMoveFunction;

public class Game
{
    public static int Move(int position, int roll)
    {
        return position + roll * 2;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.That(Game.Move(0, 4), Is.EqualTo(8));
    }
}