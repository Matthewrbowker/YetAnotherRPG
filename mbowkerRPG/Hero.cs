using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbowkerRPG
{
    class Hero : Character
    {
        protected String _name;

        public string Name { get => _name; set => _name = value; }
    }
}
