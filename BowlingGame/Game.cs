namespace BowlingGame;

public class Game
{
    private int score;

    public void Roll(int i)
    {
        score += i;
    }

    public int Score()
    {
        return score;
    }
}