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

namespace FootballAIGame {

    public class World {

        public Basic2D playerOne;

        public World() {
            playerOne = new Basic2D("2d/sprite", new Vector2(300, 300), new Vector2(48, 48));
        }

        public virtual void Update() {
            playerOne.Update();
        }

        public virtual void Draw() {
            playerOne.Draw();
        }
    }
}
