using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameEngine;

public class GameCore : Game
{
	public GameCore(string title, int preferredWidth = 1280, int preferredHeight = 720, bool isFullscreen = false, bool isMouseVisible = true, string contentDirectory = "Content")
	{
		graphics = new(this)
		{
			PreferredBackBufferWidth = preferredWidth,
			PreferredBackBufferHeight = preferredHeight,
			IsFullScreen = isFullscreen
		};

		graphics.ApplyChanges();

		Window.Title = title;

		content = Content;

		content.RootDirectory = contentDirectory;

		IsMouseVisible = isMouseVisible;
	}

	// Private Fields

	readonly GraphicsDeviceManager graphics;
	//GraphicsDevice graphicsDevice;
	SpriteBatch? spriteBatch;
	readonly ContentManager content;

	// Private Methods

	protected override void Initialize()
	{
		base.Initialize();

		//graphicsDevice = GraphicsDevice;
		spriteBatch = new(GraphicsDevice);
	}

	protected override void LoadContent()
	{
		// New code here

		base.LoadContent();
	}

	protected override void Update(GameTime gameTime)
	{
		var keyboard = Keyboard.GetState();

		if (keyboard.IsKeyDown(Keys.Escape)) Exit();

		// New code here

		base.Update(gameTime);
	}

	protected override void Draw(GameTime gameTime)
	{
		GraphicsDevice.Clear(Color.CornflowerBlue);

		// New code here

		base.Draw(gameTime);
	}
}