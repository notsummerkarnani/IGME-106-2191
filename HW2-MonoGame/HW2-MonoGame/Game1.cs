using System.Collections.Generic;
using System;
using System.Threading;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

/* Samar Karnani
 * 09/09/20
 * Prof E. Cascioli
 * HW2-MonoGame
 */

namespace HW2_MonoGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    
    //enum States is used for the Finite State Machine to have three possible states
    public enum States
    {
        Menu,
        Game,
        GameOver
    }

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        private States currentState;        //holds the current state
        private Texture2D img;              //player image texture
        private Texture2D coin;             //collectible image texture
        private SpriteFont arial50;         //font
        private SpriteFont arial18;         //font
        Player player;
        List<Collectible> collectibles;
        int currentLevel;                   //holds current level
        double time;                        //game timer
        KeyboardState kbState;              
        KeyboardState prevkbState;
        Random rng = new Random();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 600;    //sets window width
            graphics.PreferredBackBufferHeight = 600;   //sets window height
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
            currentLevel = 0;
            time = 0.0;
            currentState = States.Menu;
            
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
            img = Content.Load<Texture2D>("frame-1");
            coin = Content.Load<Texture2D>("coin_01");
            arial50 = Content.Load<SpriteFont>("font50");
            arial18 = Content.Load<SpriteFont>("arial18");
            player = new Player(img, new Rectangle(GraphicsDevice.Viewport.Width/2,GraphicsDevice.Viewport.Height/2, 100, 100));
            NextLevel();
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

            System.Console.WriteLine(player.Position.ToString());
            // TODO: Add your update logic here
            kbState = Keyboard.GetState();
            switch(currentState)    //FSM for game
            {
                case States.Menu:

                    if (SingleKeyPress(Keys.Enter))
                    {
                        currentState = States.Game;
                        ResetGame();
                    }
                    break;

                case States.Game:

                    MovePlayer();
                    ScreenWrap();


                    // checks for collision and makes collectible invisible
                    foreach (Collectible collectible in collectibles) 
                    {
                        if (collectible.CheckCollision(player) && collectible.Active == true)
                        {
                            collectible.Active = false;
                            player.LevelScore += 10;
                        }
                    }

                    //Calls the movement method for collectibles depending on the level
                    for(int i = 0; i<currentLevel; i++)
                    {
                        collectibles.ElementAt(i).Movement();
                    }

                    //checks if the player has run out of time
                    if(time <= 0)
                    {
                        currentState = States.GameOver;
                    }

                    //checks if player has completed the level
                    if(player.LevelScore == 10 * ((currentLevel * 3) + 2))
                    {
                        NextLevel();
                    }
                    time -= gameTime.ElapsedGameTime.TotalSeconds; //adjusts game time
                    prevkbState = kbState; //keeps track of prev kb state
                    break;

                case States.GameOver:
                    
                    if (SingleKeyPress(Keys.Enter))
                    {
                        currentState = States.Menu;
                    }

                    break;
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

            switch (currentState)
            {
                case States.Menu:
                    spriteBatch.DrawString(arial50, "Coin Grab!", new Vector2(150f), Color.White);
                    spriteBatch.DrawString(arial18, "Press Enter to start and WASD to move", new Vector2(100f, 300f), Color.White);
                    break;

                case States.Game:
                    spriteBatch.DrawString(arial18, String.Format("{0:0.00}", time), new Vector2(0f), Color.White);
                    spriteBatch.DrawString(arial18, $"Current Score: {player.LevelScore}", new Vector2(0f, 20f), Color.White);
                    spriteBatch.Draw(img, player.Position, Color.White);
                    foreach(Collectible collectible in collectibles)
                    {
                        collectible.Draw(spriteBatch);
                    }
                    break;

                case States.GameOver:

                    spriteBatch.DrawString(arial50, "GAME OVER!", new Vector2(100f), Color.White);
                    spriteBatch.DrawString(arial18, "You reached level " + currentLevel, new Vector2(175f), Color.White);
                    spriteBatch.DrawString(arial18, "Press Enter to restart", new Vector2(150f, 300f), Color.White);
                    break;
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }

        /// <summary>
        /// takes in no parameters and returns nothing
        /// increments level number, increases time and resets players score
        /// resets player position, empties collectible list and adds new items
        /// </summary>
        void NextLevel()
        {
            currentLevel++;
            time = 7.00 + currentLevel*4;
            player.LevelScore = 0;

            player.Position = new Rectangle(GraphicsDevice.Viewport.Width/2, GraphicsDevice.Viewport.Height/2, 100, 100);

            collectibles = new List<Collectible>();

            for(int i=0; i<((currentLevel*3)+2); i++)
            {
                collectibles.Add(new Collectible(coin, new Rectangle(rng.Next(50, 550), rng.Next(50, 550), coin.Width, coin.Height), player ));
            }
        }

        //resets the game
        void ResetGame()
        {
            currentLevel = 0;
            player.TotalScore = 0;
            NextLevel();
        }

        /// <summary>
        /// Makes sure that the player is alwys on the screen
        /// </summary>
        void ScreenWrap()
        {
            if(player.xPos >= 600)
            {
                player.xPos = 0;
            }
            if (player.yPos >= 600)
            {
                player.yPos = 0;
            }
            if (player.xPos < 0)
            {
                player.xPos = 600;
            }
            if (player.yPos < 0)
            {
                player.yPos = 600;
            }
        }

        //checks for single key press using the current and previous keyboard states
        bool SingleKeyPress(Keys key)
        {
            if(kbState.IsKeyDown(key) && prevkbState.IsKeyUp(key))
            {
                return true;
            }
            return false;
        }

        //Mehod for player movement
        void MovePlayer()
        {
            if(kbState.IsKeyDown(Keys.W))
            {
                player.yPos -= 2;
            }
            if (kbState.IsKeyDown(Keys.A))
            {
                player.xPos -= 2;
            }
            if (kbState.IsKeyDown(Keys.S))
            {
                player.yPos += 2;
            }
            if (kbState.IsKeyDown(Keys.D))
            {
                player.xPos += 2;
            }
        }
    }
}
