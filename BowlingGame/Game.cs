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
        return rolls.Sum();
    }
}