namespace BowlingGame;

public class Game
{
    private readonly int[] _rolls = new int[20];
    private int _currentRoll;

    public void Roll(int pins)
    {
        _rolls[_currentRoll++] = pins;
    }

    public int Score()
    {
        var score = 0;
        var currentFrame = 0;
        
        for (var frame = 0; frame < 10; frame++)
        {
            if (IsStrike(currentFrame))
            {
                score += CountBonusScore(currentFrame);
                currentFrame += 1;
            }
            else if (IsSpare(currentFrame))
            {
                score += CountBonusScore(currentFrame);
                currentFrame += 2;
            }
            else
            {
                score += _rolls[currentFrame] + _rolls[currentFrame + 1];
                currentFrame += 2;
            }

        }

        return score;
    }

    private int CountBonusScore(int currentFrame)
    {
        return _rolls[currentFrame] + _rolls[currentFrame+1] + _rolls[currentFrame+2];
    }

    private bool IsStrike(int currentFrame)
    {
        return _rolls[currentFrame] == 10;
    }

    private bool IsSpare(int i)
    {
        return _rolls[i]+_rolls[i+1]==10;
    }
}