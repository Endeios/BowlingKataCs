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
            if (isStrike(currentFrame))
            {
                score += CountBonusScore(currentFrame);
                currentFrame += 1;
            }
            else if (isSpare(currentFrame))
            {
                score += CountBonusScore(currentFrame);
                currentFrame += 2;
            }
            else
            {
                score += rolls[currentFrame] + rolls[currentFrame + 1];
                currentFrame += 2;
            }

        }

        return score;
    }

    private int CountBonusScore(int currentFrame)
    {
        return rolls[currentFrame] + rolls[currentFrame+1] + rolls[currentFrame+2];
    }

    private bool isStrike(int currentFrame)
    {
        return rolls[currentFrame] == 10;
    }

    private bool isSpare(int i)
    {
        return rolls[i]+rolls[i+1]==10;
    }
}