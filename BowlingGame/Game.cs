namespace BowlingGame;

public class Game
{
    private int[] rolls = new int[20];
    private int currentRoll;

    public void Roll(int pins)
    {
        rolls[currentRoll++] = pins;
    }

    public int Score()
    {
        var score = 0;
        for (var i = 0; i < rolls.Length; i++)
        {
            if (rolls[i]+rolls[i+1]==10)
            {
                score += 10;
            }
            
            score += rolls[i];
        }

        return score;
    }
}