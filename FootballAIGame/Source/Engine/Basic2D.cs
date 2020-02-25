#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
#endregion

namespace FootballAIGame
{
    public class Basic2D
    {
        public Vector2 pos, dims;
        public Texture2D mySprite;

        public Basic2D(string path, Vector2 pos, Vector2 dims)
        {
            this.pos = pos;
            this.dims = dims;
            mySprite = Globals.content.Load<Texture2D>(path);
        }
        
        public void Update() {

        }

        public void Draw() {
            if(mySprite != null) {
                //these 3 lines are 1 line
                Globals.spriteBatch.Draw(mySprite, new Rectangle((int)pos.X, (int)pos.Y, (int)dims.X, (int)dims.Y),
                    null, Color.White, 0.0f, new Vector2(mySprite.Bounds.Width / 2, mySprite.Bounds.Height / 2), 
                    new SpriteEffects(), 0);
            }
        }
    }
}
