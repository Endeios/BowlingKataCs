namespace BowlingGame;

public class Game
{
    private int score = 0;
    public void Roll(int i)
    {
        score += i;
    }

    public int Score()
    {
        return score;
    }
}