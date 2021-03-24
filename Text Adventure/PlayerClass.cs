using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class PlayerClass : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Magic { get; set; }


        public PlayerClass(string name, int health, double magic)
        {
            Name = name;
            Health = health;
            Magic = magic;
        }
    }
}
