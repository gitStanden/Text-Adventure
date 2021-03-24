using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class SpellBook : ISpellBook
    {
        //Defining features: Spell name, Spell effect(damage, healing), magic cost
        public string Name { get; set; }
        public int Effect { get; set; }
        public double MagicCost { get; set; }
        
        public SpellBook(string name, int effect, double magicCost)
        {
            Name = name;
            Effect = effect;
            MagicCost = magicCost;
        }
    }
}
