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
    class GameObject
    {
        private Texture2D img;
        private Rectangle position;

        public GameObject(Texture2D img, Rectangle position)
        {
            this.img = img;
            this.position = position;
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sb.Draw(img, position, Color.White);
        }

        //Properties

        public Rectangle Position
        { get { return position; } set { position = value; } }
        public int xPos
        { get { return position.X; } set { position.X = value; } }
        public int yPos
        { get { return position.Y; } set { position.Y = value; } }
        public Texture2D texture2D
        { get { return img; } set { img = value; } }
    }
}
