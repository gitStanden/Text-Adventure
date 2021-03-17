using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Enemy : GameClass
    {

        public Enemy(string name, int health, double magic, int minDamage, int maxDamage) : base(name, health, magic, minDamage, maxDamage)
        {
            
        }
    }
}
