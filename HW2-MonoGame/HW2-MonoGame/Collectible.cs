using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

/* Samar Karnani
 * 09/09/20
 * Prof E. Cascioli
 * HW2-MonoGame
 */

namespace HW2_MonoGame
{
    class Collectible: GameObject
    {
        private bool active;
        private int xdirection;     //direction for moving collectibles
        private int ydirection;     //direction for moving collectibles

        public Collectible(Texture2D img, Rectangle position, Player player) : base(img, position)
        {
            active = true;
        }


        /// <summary>
        /// checks if the object rectangle intersects with the collectible
        /// </summary>
        /// <param name="check"> player</param>
        /// <returns>bool value if it intersects or not</returns>
        public bool CheckCollision(GameObject check)
        {
            if(check.Position.Intersects(this.Position))
            {
                return true;
            }
            return false;
        }

        //overrides the base draw method
        public override void Draw(SpriteBatch sb)
        {
            if(this.active == true)
            {
                sb.Draw(this.texture2D, this.Position, Color.White);
            }
            return;
        }

        /// <summary>
        /// Moves the special collectibles
        /// </summary>
        public void Movement()
        {
            if (this.xPos <= 0f)
            {
                xdirection = 0;
            }
            if (this.xPos >= 600f - this.texture2D.Width)
            {
                xdirection = 1;
            }
            if (this.yPos <= 0)
            {
                ydirection = 0;
            }
            if (this.yPos >= 600 - this.texture2D.Height)
            {
                ydirection = 1;
            }

            //calls increment or decrement of Position values depending on direction
            if (xdirection == 0)
            {
                this.xPos += 1;
            }
            if (xdirection == 1)
            {
                this.xPos -= 1;
            }
            if (ydirection == 0)
            {
                this.yPos += 1;
            }
            if (ydirection == 1)
            {
                this.yPos -= 1;
            }
        }

        public bool Active
        { get { return active; } set { active = value; } } 
    }
}
