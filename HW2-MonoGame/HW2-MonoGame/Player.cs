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
    class Player: GameObject
    {
        private int levelScore;
        private int totalScore;

        public Player(Texture2D img, Rectangle position):base(img, position)
        {
            levelScore = 0;
            totalScore = 0;
        }

        //Properties

        public int LevelScore
        { get { return levelScore; } set { levelScore = value; } }
        public int TotalScore
        { get { return totalScore; } set { totalScore = value; } }
    }
}
