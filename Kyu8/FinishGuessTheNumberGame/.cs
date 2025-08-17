using System;

namespace Kyu8.FinishGuessTheNumberGame;

public class Guesser
{
    private int number;
    private int lives;

    public Guesser(int number, int lives)
    {
        this.number = number;
        this.lives = lives;
    }

    public bool Guess(int n)
    {
        if (lives <= 0)
        {
            throw new InvalidOperationException("No lives left");
        }
        if (n == number)
        {
            return true;
        }
        lives--;
        return false;
    }
}


[TestFixture]
public class KataTest
{
    [Test, Order(1)]
    public void _0_Correct_Guess_Should_Return_True()
    {
        Guesser guesser = new Guesser(10, 2);
        guesser.Guess(10);
        guesser.Guess(10);
        guesser.Guess(10);
        guesser.Guess(10);
        Assert.That(guesser.Guess(10), Is.True);
    }

    [Test, Order(2)]
    public void _1_Wrong_Guess_Should_Return_False()
    {
        Guesser guesser = new Guesser(10, 2);
        guesser.Guess(1);
        Assert.That(guesser.Guess(1), Is.False);
    }

    [Test, Order(3)]
    public void _3_Lives_Ran_Out_Should_Throw()
    {
        Guesser guesser = new Guesser(10, 2);
        guesser.Guess(1);
        guesser.Guess(2);

        bool pass = false;
        try
        {
            guesser.Guess(10);
        }
        catch
        {
            pass = true;
        }

        Assert.That(pass, Is.True, "Expected error thrown");
    }
}
