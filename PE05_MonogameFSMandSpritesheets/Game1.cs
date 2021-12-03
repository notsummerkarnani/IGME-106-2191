﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

/* Samar Karnani
 * Prof E. Cascioli
 * 28/01/19
 * PE05 Monogame FSM and Spritesheet
 */

namespace AnimationStarter_2019
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
        public enum MarioState
        {
            FaceLeft,
            WalkLeft, 
            FaceRight, 
            WalkRight
        }

		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

        private MarioState marioState;

		// Mario texture stuff
		private Texture2D marioTexture;
		private Vector2 marioPosition;
		int numSpritesInSheet;
		int widthOfSingleSprite;

		// Animation reqs
		int currentFrame;
		double fps;
		double secondsPerFrame;
		double timeCounter;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			// TODO: Add your initialization logic here

			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);

			marioTexture = Content.Load<Texture2D>("MarioSpriteSheet");
			numSpritesInSheet = 4;
			widthOfSingleSprite = marioTexture.Width / numSpritesInSheet;

			marioPosition = new Vector2(200, 200);

			// Set up animation stuff
			currentFrame = 1;
			fps = 10.0;
			secondsPerFrame = 1.0f / fps;
			timeCounter = 0;
		}


		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

            // *** Put code to check and update FINITE STATE MACHINE here
            KeyboardState kb = Keyboard.GetState();

            //checks and updates marioState
            switch(marioState)
            {
                case MarioState.FaceLeft:
                    if(kb.IsKeyDown(Keys.Left))
                    {
                        marioState = MarioState.WalkLeft;
                    }
                    else if (kb.IsKeyDown(Keys.Right))
                    {
                        marioState = MarioState.FaceRight;
                    }
                    break;
                case MarioState.FaceRight:
                    if (kb.IsKeyDown(Keys.Right))
                    {
                        marioState = MarioState.WalkRight;
                    }
                    else if (kb.IsKeyDown(Keys.Left))
                    {
                        marioState = MarioState.FaceLeft;
                    }
                    break;
                case MarioState.WalkLeft:
                    if (kb.IsKeyDown(Keys.Right))
                    {
                        marioState = MarioState.FaceRight;
                    }
                    else if (kb.IsKeyDown(Keys.Left))
                    {
                        marioPosition.X -= 2.0f;
                    }
                    else if (kb.IsKeyUp(Keys.Left))
                    {
                        marioState = MarioState.FaceLeft;
                    }
                    break;
                case MarioState.WalkRight:
                    if (kb.IsKeyDown(Keys.Right))
                    {
                        marioPosition.X += 2.0f;
                    }
                    else if (kb.IsKeyDown(Keys.Left))
                    {
                        marioState = MarioState.FaceLeft;
                    }
                    else if (kb.IsKeyUp(Keys.Right))
                    {
                        marioState = MarioState.FaceRight;
                    }
                    break;
            }

			// Update the animation
			UpdateAnimation(gameTime);
			base.Update(gameTime);
		}

		/// <summary>
		/// Updates the animation time
		/// </summary>
		/// <param name="gameTime">Game time information</param>
		private void UpdateAnimation(GameTime gameTime)
		{
			// Add to the time counter (need TOTALSECONDS here)
			timeCounter += gameTime.ElapsedGameTime.TotalSeconds;

			// Has enough time gone by to actually flip frames?
			if (timeCounter >= secondsPerFrame)
			{
				// Update the frame and wrap
				currentFrame++;
				if (currentFrame >= 4) currentFrame = 1;

				// Remove one "frame" worth of time
				timeCounter -= secondsPerFrame;
			}

		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			spriteBatch.Begin();

			//Checks marioState and draws mario accordingly
            switch(marioState)
            {
                case MarioState.FaceLeft:
                    DrawMarioStanding(SpriteEffects.FlipHorizontally);
                    break;
                case MarioState.FaceRight:
                    DrawMarioStanding(SpriteEffects.None);
                    break;
                case MarioState.WalkLeft:
                    DrawMarioWalking(SpriteEffects.FlipHorizontally);
                    break;
                case MarioState.WalkRight:
                    DrawMarioWalking(SpriteEffects.None);
                    break;
            }



			spriteBatch.End();

			base.Draw(gameTime);
		}

		/// <summary>
		/// Draws mario with a walking animation
		/// </summary>
		/// <param name="flip">Should he be flipped horizontally?</param>
		private void DrawMarioWalking(SpriteEffects flip)
		{
			spriteBatch.Draw(
				marioTexture,
				marioPosition,
				new Rectangle(widthOfSingleSprite * currentFrame, 0, widthOfSingleSprite, marioTexture.Height),
				Color.White,
				0.0f,
				Vector2.Zero,
				1.0f,
				flip,
				0.0f);
		}

		/// <summary>
		/// Draws mario standing still
		/// </summary>
		/// <param name="flip">Should he be flipped horizontally?</param>
		private void DrawMarioStanding(SpriteEffects flip)
		{
			spriteBatch.Draw(
				marioTexture,
				marioPosition,
				new Rectangle(0, 0, widthOfSingleSprite, marioTexture.Height),
				Color.White,
				0.0f,
				Vector2.Zero,
				1.0f,
				flip,
				0.0f);
		}

	}
}
