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
        var currentFrame = 0;
        
        for (var frame = 0; frame < 10; frame++)
        {
            if (isSpare(currentFrame))
            {
                score += rolls[currentFrame+2];
            }
            score += rolls[currentFrame] + rolls[currentFrame+1];
            currentFrame += 2;
        }

        return score;
    }

    private bool isSpare(int i)
    {
        return rolls[i]+rolls[i+1]==10;
    }
}