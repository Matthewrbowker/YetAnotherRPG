using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbowkerRPG
{
    abstract class Character
    {
        protected int _attack;
        protected int _defense;
        protected int _intelligence;
        protected int _strength;
        protected int _hitpoints;
        protected int _skillpoints;

        public Character()
        {
            _attack = 0;
            _defense = 0;
            _intelligence = 0;
            _strength = 0;
            _hitpoints = 0;
            _skillpoints = 0;
        }

        public void Attack(int attackValue)
        {
            _hitpoints = _hitpoints - attackValue;
        }

        public void Defend(Villain v)
        {
            v.Attack(_attack);
        }
    }
}
