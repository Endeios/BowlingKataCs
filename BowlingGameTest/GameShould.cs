using BowlingGame;

namespace BowlingGameTest;

public class GameShould
{
    private Game game;

    [SetUp]
    public void Setup()
    {
        game = new Game();
    }

    [Test]
    public void CreateAGame()
    {
        Assert.That(game, Is.Not.Null);
    }

    [Test]
    public void SupportGutterGame()
    {
        RollTimes(0, 20);

        Assert.That(game.Score(), Is.EqualTo(0));
    }

    [Test]
    public void SupportAllOnes()
    {
        RollTimes(1, 20);

        Assert.That(game.Score(), Is.EqualTo(20));
    }

    private void RollTimes(int score, int rolls)
    {
        for (var i = 0; i < rolls; i++) game.Roll(score);
    }
}