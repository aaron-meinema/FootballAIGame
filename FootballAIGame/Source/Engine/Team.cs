using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballAIGame {
    class Team {

        private LinkedList<FootballPlayer> players;
        private LinkedList<Task> tasks;

        public Team(LinkedList<FootballPlayer> players) {
            this.players = players;
            SetTasks(); 
        }

        public void SetTasks() {

        }


        public void Update() {
            foreach(FootballPlayer player in players) {
                player.Update();
            }
        }

        public void Draw() {
            foreach(FootballPlayer player in players) {
                player.Draw();
            }
        }

    }
}
