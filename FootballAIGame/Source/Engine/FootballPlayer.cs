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
    class FootballPlayer
    {
        public Vector2 pos;
        public Vector2 dims;
        public string name;
        public int speed;
        public int strength;
        public int price;
        public string path;
        private delegate void delegateMovement();

        public FootballPlayer(Vector2 pos, Vector2 dims, string name, int speed, 
            int strength, int price, string path, string playerType) {
            this.pos = pos;
            this.dims = dims;
            this.name = name;
            this.speed = speed;
            this.strength = strength;
            this.price = price;
            this.path = path;
            SetDeligate(playerType);
        }

        private void SetDeligate(string playerType) {
            switch (playerType)
            {

            }
        }

        public void Update() {

        }

        public void Draw() {

        }
    }
}
