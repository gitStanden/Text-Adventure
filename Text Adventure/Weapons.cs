using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Weapons : IWeapons
    {
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapons(string name, int minDamage, int maxDamage)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

    }
}
