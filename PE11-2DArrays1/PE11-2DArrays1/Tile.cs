using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class Tile
    {
        private Rectangle rectangle;
        private Texture2D texture;

        public Tile(Texture2D texture, Rectangle rectangle)
        {
            this.texture = texture;
            this.rectangle = rectangle;
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(this.texture, this.rectangle, Color.White);
        }

        public void Changetexture(Texture2D texture)
        {
            this.texture = texture;
        }
    }
}
