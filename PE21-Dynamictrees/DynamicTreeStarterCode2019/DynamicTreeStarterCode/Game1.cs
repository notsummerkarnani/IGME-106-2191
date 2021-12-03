using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading;

/* Samar Karnani
 * PE21 Dynamic trees
 * Prof E. Cascioli / Prof. Alberto
 * 11/4/20
 */

namespace DynamicTreeStarterCode
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		// The three trees
		Tree treeRed;
		Tree treeGreen;
		Tree treeBlue;

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

			// Create the three trees
			treeRed = new Tree(spriteBatch, Color.Red);
			treeGreen = new Tree(spriteBatch, Color.Green);
			treeBlue = new Tree(spriteBatch, Color.DodgerBlue);

            // *** FILL EACH TREE WITH DATA HERE ***************************
            //inserts data that will always go on the right, therefore creating a circle
            for(int i = 1; i<100; i++)
            {
                treeGreen.Insert(i);
            }

            //inserts data randomly
            Random rng = new Random();
            for (int i = 1; i < 100; i++)
            {
                treeRed.Insert(rng.Next(1000));
            }

            //i was unsure about what the blue tree was supposed to be 
            //inserts data randomly but in such a way that the data tends to the right 
            int random = 40;
            for (int i = 0; i<100; i++)
            {
                random = rng.Next(random - 40, random + 60);
                treeBlue.Insert(random);
            }
        }

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// game-specific content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
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

            // **********************************************
            // After you have the rest of the assignment working:
            //  What happens if you insert a new piece of 
            //  data into the trees each frame?
            // **********************************************
            
            //the number of branches increases significantly and my Visual Studio crashed 

            base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			// Draw the trees
			treeRed.Draw(new Vector2(200, 400));
			treeGreen.Draw(new Vector2(400, 400));
			treeBlue.Draw(new Vector2(600, 400));

			base.Draw(gameTime);
		}
	}
}
