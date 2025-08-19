namespace Kyu5.TicTacToeChecker;

public class TicTacToe
{
    public int IsSolved(int[,] board)
    {
        if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != 0)
            return board[0, 0];
        if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != 0)
            return board[1, 0];
        if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != 0)
            return board[2, 0];
        if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != 0)
            return board[0, 0];
        if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] != 0)
            return board[0, 1];
        if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != 0)
            return board[0, 2];
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
            return board[0, 0];
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
            return board[0, 2];
        if (board[0, 0] == 0 || board[0, 1] == 0 || board[0, 2] == 0 || board[1, 0] == 0 || board[1, 1] == 0 || board[1, 2] == 0 || board[2, 0] == 0 || board[2, 1] == 0 || board[2, 2] == 0)
            return -1;
        return 0;
    }
}


[TestFixture]
public class TicTacToeTest
{
    private TicTacToe tictactoe = new TicTacToe();

    [Test]
    public void test1()
    {
        int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
        Assert.That(tictactoe.IsSolved(board), Is.EqualTo(1));
    }
}
