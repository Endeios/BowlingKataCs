using BowlingGame;

namespace BowlingGameTest;

public class GameShould
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CreateAGame()
    {
        var game = new Game();
        Assert.That(game, Is.Not.Null);
    }
}