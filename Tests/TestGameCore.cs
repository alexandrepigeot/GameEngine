using GameEngine;

namespace Tests;

[TestClass]
public sealed class TestGameCore
{
	[TestMethod]
	public void TestConstructor()
	{
		using var game1 = new GameCore("game1");

		game1.RunOneFrame();

		Assert.IsTrue(game1.IsActive);
	}
}
