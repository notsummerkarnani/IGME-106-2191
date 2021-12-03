using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

/* Samar Karnani
 * Erin Cascioli
 * 16/02/20
 * PE11-2DArrays
 */

namespace PE11_2DArrays1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D dirt;
        private Texture2D dirt1;
        private Texture2D grass;
        private Texture2D grass1;
        private Texture2D sky;
        private Texture2D sky1;
        private int rows;
        private int columns;
        private Tile[,] grid;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 900;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 900;   // set this value to the desired height of your window
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
            columns = 10;
            rows = 6;
            grid = new Tile[columns, rows];
            System.Console.WriteLine(grid.Length);
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
            dirt = Content.Load<Texture2D>("dirt");
            dirt1 = Content.Load<Texture2D>("dirt_border");
            grass = Content.Load<Texture2D>("grass");
            grass1 = Content.Load<Texture2D>("grass_border");
            sky = Content.Load<Texture2D>("sky");
            sky1 = Content.Load<Texture2D>("sky_border");

            //Adds the tiles to the grid based on their row
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if(j<4)
                    {
                        grid[i, j] = new Tile(sky, new Rectangle(i * GraphicsDevice.Viewport.Width / columns, j * GraphicsDevice.Viewport.Height / rows, GraphicsDevice.Viewport.Width / columns, GraphicsDevice.Viewport.Height / rows));
                    }
                    if (j == 4)
                    {
                        grid[i, j] = new Tile(grass, new Rectangle(i * GraphicsDevice.Viewport.Width / columns, j * GraphicsDevice.Viewport.Height / rows, GraphicsDevice.Viewport.Width / columns, GraphicsDevice.Viewport.Height / rows));
                    }
                    if (j > 4)
                    {
                        grid[i, j] = new Tile(dirt, new Rectangle(i * GraphicsDevice.Viewport.Width / columns, j * GraphicsDevice.Viewport.Height / rows, GraphicsDevice.Viewport.Width / columns, GraphicsDevice.Viewport.Height / rows));
                    }
                }
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
            foreach (Tile value in grid)
            {
                value.Draw(spriteBatch);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}