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
        var i = 0;
        
        for (var frame = 0; frame < 10; frame++)
        {
            score += rolls[i] + rolls[i+1];
            i += 2;
        }

        return score;
    }
}