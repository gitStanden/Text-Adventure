using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Enemy : ICharacter
    {
        public string Name { get; set; }
        public int Health {get; set;}
        public double Magic { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public Enemy(string name, int health, double magic, int minDamage, int maxDamage)
        {
            Name = name;
            Health = health;
            Magic = magic;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        
    }
}
