using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbowkerRPG
{
    class Game
    {
        private Hero[] _heroes;
        private Villain[] _villains;
        private String ordered;
        private int _turn;

        private void Order()
        {
            // H0 - first hero
            // V2 - Third villain


        }

        public Game()
        {
            ResetGame();
            
        }

        public void ResetGame()
        {
            _heroes = new Hero[3];
            _villains = new Villain[3];

            _turn = 0;

            _heroes[0] = new Warrior();
        }

        public void Turn()
        {

        }

    }
}
