using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    interface ICharacter
    {
        string Name { get; set; }
        int Health { get; set; }
        double Magic { get; set; }
        //Spells
    }
}
