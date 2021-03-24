using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    interface ISpellBook
    {
        //Defining features: Spell name, Spell effect(damage, healing, DoT), magic cost
        string Name { get; set; }
        int Effect { get; set; }
        double MagicCost { get; set; }

    }
}
