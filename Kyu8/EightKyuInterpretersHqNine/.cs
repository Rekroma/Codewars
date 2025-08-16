namespace Kyu8.EightKyuInterpretersHqNine;

public class HQ9
{
    public static string Interpret(string code)
    {
        switch (code)
        {
            case "H":
                return "Hello World!";
            case "Q":
                return "Q";
            case "9":
                return GetBeerSong();
            default:
                return null;
        }
    }

    private static string GetBeerSong()
    {
        var lyrics = new System.Text.StringBuilder();

        for (int i = 99; i > 0; i--)
        {
            string bottleCount = (i == 1) ? "1 bottle" : $"{i} bottles";
            string nextBottleCount = (i - 1 == 1) ? "1 bottle" : $"{i - 1} bottles";

            lyrics.AppendLine($"{bottleCount} of beer on the wall, {bottleCount} of beer.");
            lyrics.AppendLine($"Take one down and pass it around, {(i - 1 > 0 ? nextBottleCount : "no more bottles")} of beer on the wall.");
        }
        lyrics.AppendLine("No more bottles of beer on the wall, no more bottles of beer.");
        lyrics.AppendLine("Go to the store and buy some more, 99 bottles of beer on the wall.");

        return lyrics.ToString().Trim();
    }
}