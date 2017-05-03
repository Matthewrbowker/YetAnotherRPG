using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbowkerRPG
{
    class Warrior : Hero
    {
        public Warrior()
        {
            _attack = 100;
            _defense = 75;
            _intelligence = 10;
            _strength = 100;
            _hitpoints = 100;
            _skillpoints = 3;
            _name = "Warrior";
        }
    }
}
