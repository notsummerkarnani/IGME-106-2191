using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

/* Samar Karnani
 * Prof E. Cascioli / Prof A. Bobadilla
 * 29/03/2020
 * PE19 Recursion
 */

namespace PE19_Recursion
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D image;    //image

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

            // TODO: use this.Content to load your game content here
            image = Content.Load<Texture2D>("img");
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
            System.Console.WriteLine(DrawRecursiveThing(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, Color.Green)); // writes output to console
            spriteBatch.End();
            base.Draw(gameTime);
        }

        /// <summary>
        /// recursive method that draws all the images 
        /// </summary>
        /// <param name="x"> x position for the image</param>
        /// <param name="y"> y position for the image </param>
        /// <param name="width"> width of the image </param>
        /// <param name="height">height of the image </param>
        /// <param name="color">colour tint for the image </param>
        /// <returns> number of images drawn to the screen == 63 </returns>
        private int DrawRecursiveThing(int x, int y, int width, int height, Color color)
        {
            
            spriteBatch.Draw(image, new Rectangle(x, y, width, height), color);

            if (width <= 20 || height <= 20) //base condition which stops recursion
            {
                return 1;
            }

            //to alternate between green aand white colours
            if(color.Equals(Color.Green))
            {
                color = Color.White;
            }
            else
            {
                color = Color.Green;
            }

            return 1 + DrawRecursiveThing(x, y, width / 2, height / 2, color) + DrawRecursiveThing(x + width / 2, y + height / 2, width / 2, height / 2, color);

        }
    }
}
