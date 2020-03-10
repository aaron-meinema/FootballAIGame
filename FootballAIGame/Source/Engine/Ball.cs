using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;


namespace FootballAIGame
{
    class Ball
    {
        private string path;
        private Vector2 pos;
        private Vector2 dims;

        public Ball(string path, Vector2 pos, Vector2 dims)
        {
            this.path = path;
            this.pos = pos;
            this.dims = dims;
        }

        public void Update() {

        }

        public void Draw() {

        }
    }
}
