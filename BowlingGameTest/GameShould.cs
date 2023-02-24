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

    [Test]
    public void SupportGutterGame()
    {
        var game = new Game();
        for (int i = 0; i < 20; i++)
        {
            game.Roll(0);
        }
        
        Assert.That(game.Score(), Is.EqualTo(0));
    }

    [Test]
    public void SupportAllOnes()
    {
         var game = new Game();
                for (int i = 0; i < 20; i++)
                {
                    game.Roll(1);
                }
                
                Assert.That(game.Score(), Is.EqualTo(20));
    }
}