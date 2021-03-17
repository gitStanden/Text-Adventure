using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    interface IWeapons
    {
        string Name { get; set; }
        int MinDamage { get; set; }
        int MaxDamage {get; set;}
    }
}
