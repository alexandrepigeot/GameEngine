using GameEngine;

namespace TestGame;

[TestClass]
public sealed class TestCore
{
	[TestMethod]
	public void TestCreateEmptyGame()
	{
		using var game = new GameCore("Empty test game");

		game.RunOneFrame();

		Assert.IsTrue(game.IsActive);
	}
}
