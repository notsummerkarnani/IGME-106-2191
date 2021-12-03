using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

/* Samar Karnani
 * Prof E. Cascioli
 * 30/01/19
 * PE06 Monogame Collision
 */

namespace PE06_MonogameCollision
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private Texture2D img;
        private Texture2D img1;
        private Rectangle wasd;
        private List<Rectangle> rectangles = new List<Rectangle>();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1000;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 1000;   // set this value to the desired height of your window
            graphics.ApplyChanges();
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
            rectangles.Add(new Rectangle(0, 0, 100, 100));
            rectangles.Add(new Rectangle(300, 0, 100, 100));
            rectangles.Add(new Rectangle(0, 300, 100, 100));
            rectangles.Add(new Rectangle(600, 0, 100, 100));
            rectangles.Add(new Rectangle(0, 600, 100, 100));
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

            img = Content.Load<Texture2D>("y");
            img1 = Content.Load<Texture2D>("n");

            wasd = new Rectangle(0, 0, img.Width/4, img.Height/4);
            // TODO: use this.Content to load your game content here
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

            // TODO: Add your update logic here
            KeyboardState kb = Keyboard.GetState();

            //Movement logic for rectangle wasd
            if (kb.IsKeyDown(Keys.W))
            {
                wasd.X += 0;
                wasd.Y += -5;
            }
            if (kb.IsKeyDown(Keys.A))
            {
                wasd.X += -5;
                wasd.Y += 0;
            }
            if (kb.IsKeyDown(Keys.S))
            {
                wasd.X += 0;
                wasd.Y += 5;
            }
            if (kb.IsKeyDown(Keys.D))
            {
                wasd.X += 5;
                wasd.Y += 0;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            spriteBatch.Draw(img, wasd, Color.White);
            foreach(Rectangle value in rectangles)
            {
                if (value.Intersects(wasd))
                {
                    spriteBatch.Draw(img1, value, Color.Purple);
                }
                else
                {
                    spriteBatch.Draw(img1, value, Color.White);
                }
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
