using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class Button
    {
        private Texture2D img1;         
        private Texture2D img2;
        private Rectangle rectangle = new Rectangle(450, 0, 150, 100);

        public Button(Texture2D img1, Texture2D img2)
        {
            this.img1 = img1;
            this.img2 = img2;
        }

        //takes in spritebatch object and mousestate to determine which image will be drawn for the button
        public void Draw(SpriteBatch sb, MouseState ms)
        {
            
            if(ms.X>= 450 && ms.X<=600 && ms.Y >=0 && ms.Y <=100)
            {
                sb.Draw(img1, rectangle, Color.White);
            }
            else
            {
                sb.Draw(img2, rectangle, Color.White);
            }
            
        }

    }
}
