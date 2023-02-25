using BowlingGame;

namespace BowlingGameTest;

public class GameShould
{
    private Game _game;

    [SetUp]
    public void Setup()
    {
        _game = new Game();
    }

    [Test]
    public void CreateAGame()
    {
        Assert.That(_game, Is.Not.Null);
    }

    [Test]
    public void SupportGutterGame()
    {
        RollTimes(0, 20);

        Assert.That(_game.Score(), Is.EqualTo(0));
    }

    [Test]
    public void SupportAllOnes()
    {
        RollTimes(1, 20);

        Assert.That(_game.Score(), Is.EqualTo(20));
    }

    [Test]
    public void SupportOneSpare()
    {
        _game.Roll(5);
        _game.Roll(5);
        _game.Roll(3);
        RollTimes(0, 17);
        
        Assert.That(_game.Score(), Is.EqualTo(16));
    }

    [Test]
    public void SupportStrike()
    {
        _game.Roll(10);
        _game.Roll(3);
        _game.Roll(4);
        RollTimes(0, 16);
        
        Assert.That(_game.Score(), Is.EqualTo(24));
    }

    [Test]
    public void SupportPerfectGame()
    {
        
        RollTimes(10, 12);
        
        Assert.That(_game.Score(), Is.EqualTo(300));
    }

    private void RollTimes(int score, int rolls)
    {
        for (var i = 0; i < rolls; i++) _game.Roll(score);
    }
}