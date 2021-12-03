using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

/* Samar Karnani
 * GDAPS2 Prof E. Cascioli
 * 26/01/2019
 * PE04 Monogame- Text and input
 */

namespace PE03_MonoGameBasics
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D img;
        private Vector2 vector;
        private int xdirection;         //is assigned values 0 or 1 for direction
        private int ydirection;         //is assigned values 0 or 1 for direction
        private Vector2 wasd;           //controller for smaller image
        private SpriteFont arial40;
        Button button;
        MouseState ms;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1920;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 1080;   // set this value to the desired height of your window
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
            vector = new Vector2(0f, 0f);
            xdirection = 0;
            ydirection = 0;
             
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

            // TODO: use this.Content to load your game content here
            img = Content.Load<Texture2D>("Playstation");
            button = new Button(Content.Load<Texture2D>("y"),Content.Load<Texture2D>("n"));
            arial40 = Content.Load<SpriteFont>("Arial40");
            wasd = new Vector2(300 - (img.Width / 2), 300 - (img.Width / 2));
            base.LoadContent();
        }

        protected void ProcessInput()
        {
            KeyboardState kb = Keyboard.GetState();

            if(kb.IsKeyDown(Keys.W))
            {
                wasd.X += 0f;
                wasd.Y += -1f;
            }
            if (kb.IsKeyDown(Keys.A))
            {
                wasd.X += -1f;
                wasd.Y += 0f;
            }
            if (kb.IsKeyDown(Keys.S))
            {
                wasd.X += 0f;
                wasd.Y += 1f;
            }
            if (kb.IsKeyDown(Keys.D))
            {
                wasd.X += 1f;
                wasd.Y += 0f;
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

            // TODO: Add your update logic here
            // changes direction based on vector
            if (vector.X <= 0f)
            {
                xdirection = 0;
            }
            if (vector.X >= 600f-177f)
            {
                xdirection = 1;
            }
            if (vector.Y <= 0)
            {
                ydirection = 0;
            }
            if (vector.Y >= 600-140f)
            {
                ydirection = 1;
            }

            //calls increment or decrement of vector values depending on direction
            if (xdirection == 0)
            {
                vector.X += 1f; 
            }
            if (xdirection == 1)
            {
                vector.X -= 1f;
            }
            if (ydirection == 0)
            {
                vector.Y += 1f;
            }
            if (ydirection == 1)
            {
                vector.Y -= 1f;
            }
            
            ProcessInput();

            ms = Mouse.GetState();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Lavender);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(img, vector, Color.White);     //draws image with vector
            spriteBatch.Draw(img, wasd, Color.White);  //draws image with rectangle
            spriteBatch.DrawString(arial40, "420", new Vector2(0f, 0f), Color.HotPink); 
            spriteBatch.DrawString(arial40, wasd.ToString(), new Vector2(0f, 50f), Color.HotPink);
            button.Draw(spriteBatch, ms);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
